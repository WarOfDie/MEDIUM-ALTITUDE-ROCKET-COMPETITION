/*
 * kalman.c
 *
 *  Created on: 13 Ağu 2024
 *      Author: alper
 */
#include "kalman.h"

double Kalman_getPressure(Kalman_t *Kalman, float newPressure, double newPressureRate, double dt) {
    // Basınç oranını ölçüm sapması ile düzeltin
    double rate = newPressureRate - Kalman->bias;
    // Tahmin edilen basıncı güncelleyin
    double pressure = rate * dt;

    // Hata kovaryans matrisini güncelleyin
    Kalman->P[0][0] += dt * (dt * Kalman->P[1][1] - Kalman->P[0][1] - Kalman->P[1][0] + Kalman->Q_pressure);
    Kalman->P[0][1] -= dt * Kalman->P[1][1];
    Kalman->P[1][0] -= dt * Kalman->P[1][1];
    Kalman->P[1][1] += Kalman->Q_bias * dt;

    // Kalman kazancı hesaplaması
    double S = Kalman->P[0][0] + Kalman->R_measure;
    double K[2];
    K[0] = Kalman->P[0][0] / S;
    K[1] = Kalman->P[1][0] / S;

    // Ölçülen basınç ile tahmin edilen basınç arasındaki fark
    double y = newPressure - pressure;

    // Tahmin edilen basıncı düzeltin
    pressure += K[0] * y;
    Kalman->bias += K[1] * y;

    // Hata kovaryans matrisini güncelleyin
    double P00_temp = Kalman->P[0][0];
    double P01_temp = Kalman->P[0][1];

    Kalman->P[0][0] -= K[0] * P00_temp;
    Kalman->P[0][1] -= K[0] * P01_temp;
    Kalman->P[1][0] -= K[1] * P00_temp;
    Kalman->P[1][1] -= K[1] * P01_temp;

    // Tahmin edilen basıncı döndürün
    return pressure;
}
