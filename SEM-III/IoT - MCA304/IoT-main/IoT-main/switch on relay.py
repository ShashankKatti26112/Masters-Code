import RPi.GPIO as GPIO
import time

# Set up GPIO
GPIO.setmode(GPIO.BOARD)
relay_pin = 38
GPIO.setup(relay_pin, GPIO.OUT)

# Function to switch on the relay
def switch_on_relay():
    GPIO.output(relay_pin, GPIO.HIGH)

# Schedule this script to run at a specific time using cron
# Example cron entry: 0 12 * * * /usr/bin/python3 /path/to/script.py
# This runs the script every day at 12:00 PM
try:
    switch_on_relay()
    time.sleep(5)  # Keep the relay on for 5 seconds (adjust as needed)
    GPIO.cleanup()

except KeyboardInterrupt:
    GPIO.cleanup()
