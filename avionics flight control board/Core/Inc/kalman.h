/*
 * kalman.h
 *
 *  Created on: 13 Ağu 2024
 *      Author: alper
 */

#ifndef INC_KALMAN_H_
#define INC_KALMAN_H_

typedef struct {
    double Q_pressure;  // Tahmin edilen basınç hata kovaryansı
    double Q_bias;      // Sapma hata kovaryansı
    double R_measure;   // Ölçüm hata kovaryansı
    double bias;        // Ölçüm sapması
    double P[2][2];     // Hata kovaryans matrisi
} Kalman_t;

double Kalman_getPressure(Kalman_t *Kalman, float  newPressure, double newPressureRate, double dt);

#endif /* INC_KALMAN_H_ */
