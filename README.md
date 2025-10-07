# MEDIUM-ALTITUDE ROCKET COMPETITION

MCU-based avionics, telemetry and ground-station software for a medium-altitude rocket project.

> **Short description:** This repository contains firmware and software components developed for a medium-altitude rocket competition: flight avionics (flight control board), an ESP32-CAM telemetry/vision node, and the ground station software for telemetry reception, visualization and logging.



## Project Overview

This project implements the electronics, firmware and ground software required to operate and monitor a medium-altitude rocket: sensing (IMU/GPS/pressure), flight control (state estimation, apogee detection, deployment logic), telemetry downlink (LoRa/serial), and a ground station GUI for real-time telemetry and logging.

The repository is organized into separate modules for on-board avionics, an ESP32-CAM node, and the ground station.

---

## Repository Structure

```
/ (root)
├─ ESP32 CAM/                # ESP32-CAM related code, camera streaming and telemetry
├─ avionics flight control board/  # STM32 flight computer firmware, drivers, algorithms
└─ ground station software/  # Desktop app for telemetry reception, plotting, logging
```

---

## Hardware 

The project uses typical flight avionics components :

* **Flight computer:** STM32 (e.g., STM32F446RE) MCU.
* **IMU:** MPU9250 / similar (accelerometer, gyroscope, magnetometer).
* **GPS:** NEO-8M / compatible GNSS module.
* **Barometer:** MS5803-style high-precision pressure sensor for altitude.
* **Radio/Telemetry:** LoRa E32 or similar LoRa modem for downlink.
* **Camera node:** ESP32-CAM module for capture/streaming and optionally downlinking small images.
* **Power:** Regulated 3.3V/5V rails with decoupling and a battery capable of the peak current draw of the flight electronics.

> Note: If your hardware BOM differs, update the README to reflect exact parts and connectors.

---

## Software & Firmware Overview

### Avionics (flight control board)

* Language: C (STM HAL or bare-metal drivers).
* Responsibilities: Sensor reading (IMU/GPS/Baro), sensor fusion / state estimation, apogee detection, recovery deployment (pyro/servo), telemetry framing and transmission (LoRa / UART).


### ESP32-CAM

* Language/framework: Arduino / ESP-IDF (depending on files).
* Responsibilities: Camera capture, optional local SD logging.

### Ground Station Software

* Likely implemented in C# or another desktop stack.
* Responsibilities: Open telemetry serial port, parse frames, visualize telemetry in real-time, save logs.





---

## Troubleshooting (common issues)

* **ESP32 CAM resets / core dumps:** insufficient power is the most common cause; ensure a stable 5V supply capable of 1.5–2A and good ground. Also enable serial logging via `Serial` to capture core dump messages for debugging.
* **Telemetry packet loss:** check LoRa settings (airtime, spreading factor), ensure antenna and TX power configured correctly, and check ground station radio configuration.
* **Sensor calibration / drift:** calibrate IMU before each campaign; use complementary/kalman filtering for altitude/attitude estimation.

---

## Deployment Checklist (pre-flight)

* Fully charged and tested battery pack.
* Verify SD / logger write speed (if used).
* Verify pyrotechnic or deployment mechanism arming/disarming per safety rules.
* Sanity check telemetry link & ground station reception.
* Confirm fail-safe code paths (e.g., auto-deploy on telemetry loss or on timeout as per rules).


