import RPi.GPIO as GPIO
import time

def flash_led(led_pin, on_time, off_time):
    GPIO.setmode(GPIO.BOARD)
    GPIO.setup(led_pin, GPIO.OUT)

    try:
        while True:
            GPIO.output(led_pin, GPIO.HIGH)
            time.sleep(on_time)
            GPIO.output(led_pin, GPIO.LOW)
            time.sleep(off_time)

    except KeyboardInterrupt:
        pass

    finally:
        GPIO.cleanup()

# Read on_time and off_time from a file (assuming one value per line)
with open("led_times.txt", "r") as file:
    on_time = float(file.readline().strip())
    off_time = float(file.readline().strip())

# Set the LED pin (assuming it's connected to GPIO pin 15)
led_pin = 15

# Start flashing the LED
flash_led(led_pin, on_time, off_time)
