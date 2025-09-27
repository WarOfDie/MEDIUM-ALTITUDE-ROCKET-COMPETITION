/*
 * ms5803.c
 *
 *  Created on: Feb 22, 2021
 *      Author: Ravi Kirschner
 */

#include "ms5803.h"
#include "kalman.h"

Kalman_t KalmanX = {
    .Q_pressure = 0.001,  // Tahmin edilen basınç hata kovaryansı
    .Q_bias = 0.003,      // Sapma hata kovaryansı
    .R_measure = 0.03,    // Ölçüm hata kovaryansı
    .bias = 0.0,          // Başlangıçta sapma sıfır olarak ayarlanabilir
    .P = {{0, 0}, {0, 0}} // Hata kovaryans matrisi sıfırdan başlatılır
};

uint16_t MS5803_coefficient[6] = {0}; //coefficients
/**
 * @brief Reads from MS5803
 * @param handle The I2C handle being used
 * @param bufp The buffer to be read into
 * @param len The length of the buffer in 8-bit increments
 * @retval HAL Status
 */
HAL_StatusTypeDef MS5803_read(void *handle, uint8_t *bufp, uint16_t len) {
	return HAL_I2C_Master_Receive(handle, MS5803_ADDR, bufp, len, 1000);
}

/**
 * @brief Writes to MS5803
 * @param handle The I2C handle being used
 * @param bufp The buffer to read from
 * @param len The length of the buffer in 8-bit increments
 * @retval HAL Status
 */
HAL_StatusTypeDef MS5803_write(void *handle, uint8_t *bufp, uint16_t len) {
	return HAL_I2C_Master_Transmit(handle, MS5803_ADDR, bufp, len, 1000);
}

/**
 * @brief Resets the MS5803
 * @param handle The I2C Handle being used
 * @retval HAL Status
 */
HAL_StatusTypeDef MS5803_reset(void *handle) {
	uint8_t buf;
	buf = MS5803_RESET;
	HAL_StatusTypeDef ret = HAL_I2C_Master_Transmit(handle, MS5803_ADDR, &buf, 1, 100);
	HAL_Delay(3);

	return ret;
}

/**
 * @brief Gets the 6 Coefficients from the MS5803 and reads them into the MS5803_coefficient array.
 * @param handle The I2C Handle being used
 * @param coeff The pointer to the coefficient being read in to
 * @param value The coefficient number
 * @return HAL Status
 */
void MS5803_Init(void *handle, uint8_t i) {
	uint8_t buf;
	for(int i = 1; i <= 6; i++) {
		buf = MS5803_PROM + (i << 1); //coefficient to read
		MS5803_write(handle, &buf, 1); //tell MS5803 that we want it

		uint8_t c[2];
		HAL_I2C_Master_Receive(handle, MS5803_ADDR, c, 2, 100);
		//MS5803_read(handle, &c, 2); //read the coefficient
		MS5803_coefficient[i-1] = (c[0]<<8)|c[1]; //turn the two 8-bit values into one coherent value.
	}

}

/**
 * @brief Reads the MS5803 ADC
 * @param handle The I2C Handle being used
 * @param type The measurement type, chosen from measurement enum
 * @param prec The precision to use, chosen from precision enum
 * @retval Raw 24-bit data from the ADC
 */
uint32_t MS5803_ADC(void *handle, measurement type, precision prec) {
	uint32_t result;
	uint8_t buf[4];
	buf[0] = MS5803_ADC_CONV + type + prec; //tell the ADC to convert along with the precision and type
	MS5803_write(handle, buf, 1);
	HAL_Delay(1);
	switch(prec) {
	case ADC_256: HAL_Delay(1);
	case ADC_512: HAL_Delay(3);
	case ADC_1024: HAL_Delay(4);
	case ADC_2048: HAL_Delay(6);
	case ADC_4096: HAL_Delay(10); //Delay longer if higher precision, as conversion takes longer.
	}
	buf[0] = MS5803_ADC_READ; //Tell the MS5803 that we want to read the ADC
	MS5803_write(handle, buf, 1);

	//uint8_t c[3];
	MS5803_read(handle, buf, 3); //Read out the ADC
	result = (buf[0] << 16) | (buf[1] << 8) | buf[2]; //Convert the three 8-bit values into one value.
	return result;
}

/**
 * @brief Gets temperature and pressure values from the MS5803
 * @param handle The I2C Handle being used
 * @param prec The precision to be used
 * @param temperature The pointer to the temperature variable being read in to.
 * @param pressure The pointer to the pressure variable being read in to.
 */
void MS5803_get_values(void *handle, precision prec, float *temperature, float *pressure) {
	uint32_t temperature_raw = MS5803_ADC(handle, TEMPERATURE, prec);
	uint32_t pressure_raw = MS5803_ADC(handle, PRESSURE, prec); //get temperature and pressure raw values

	int32_t temp_calc;
	int32_t pressure_calc;

	int32_t dT;

	dT = temperature_raw - ((int32_t)MS5803_coefficient[4] << 8);
	temp_calc = (((int64_t)dT * MS5803_coefficient[5]) >> 23) + 2000;
	//*temperature = temp/100.f; //determine temperature according to datasheet

	int64_t T2, OFF2, SENS2, OFF, SENS;

	if (temp_calc < 2000)
		// If temp_calc is below 20.0C
		{
			T2 = 3 * (((int64_t)dT * dT) >> 33);
			OFF2 = 3 * ((temp_calc - 2000) * (temp_calc - 2000)) / 2;
			SENS2 = 5 * ((temp_calc - 2000) * (temp_calc - 2000)) / 8;

			if (temp_calc < -1500)
			// If temp_calc is below -15.0C
			{
				OFF2 = OFF2 + 7 * ((temp_calc + 1500) * (temp_calc + 1500));
				SENS2 = SENS2 + 4 * ((temp_calc + 1500) * (temp_calc + 1500));
			}
		}
		else
		// If temp_calc is above 20.0C
		{
			T2 = 7 * ((uint64_t)dT * dT) / pow(2, 37);
			OFF2 = ((temp_calc - 2000) * (temp_calc - 2000)) / 16;
			SENS2 = 0;
		}

		// Now bring it all together to apply offsets

		OFF = ((int64_t)MS5803_coefficient[1] << 16) + (((MS5803_coefficient[3] * (int64_t)dT)) >> 7);
		SENS = ((int64_t)MS5803_coefficient[0] << 15) + (((MS5803_coefficient[2] * (int64_t)dT)) >> 8);

		temp_calc = temp_calc - T2;
		OFF = OFF - OFF2;
		SENS = SENS - SENS2;

		// Now lets calculate the pressure

		pressure_calc = (((SENS * pressure_raw) / 2097152) - OFF) / 32768;



//	int64_t add = MS5803_coefficient[3]*dT/128;
//	int64_t OFF = (MS5803_coefficient[1]*65536)+add;
//	int64_t SENS = (MS5803_coefficient[0] * 32768) + (MS5803_coefficient[2]*dT/256);
//	int64_t mult = pressure_raw*SENS/2097152;
//	int32_t pres = (mult-OFF)/32768;

	*pressure = Kalman_getPressure(&KalmanX, (pressure_calc / 10.0f), 0.5, 0.5); //determine pressure according to datasheet
	*temperature = temp_calc/ 100.0f;
}

