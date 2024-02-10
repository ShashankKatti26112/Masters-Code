import RPi.GPIO as gpio
import time
import datetime

gpio.setwarnings(False)
gpio.setmode(gpio.BOARD)

led1=13
gpio.setup(led1,gpio.OUT,initial=0)

from flask import Flask,render_template

app=Flask(__name__)

@app.route('/')
def hello_world():
    return render_template('mywebpage1.html')
    
@app.route('/redledon')
def redledon():
    gpio.output(13,gpio.LOW)
    now=datetime.datetime.now()
    timestring=now.strftime("%Y-%m_%d %H:%M")
    templateData={'status':'ON','time':timestring}
    return render_template('mywebpage.html',**templateData)

@app.route('/redledoff')
def redledoff():
    gpio.output(13,gpio.HIGH)
    now=datetime.datetime.now()
    timestring=now.strftime("%Y-%m_%d %H:%M")
    templateData={'status':'OFF','time':timestring}
    return render_template('mywebpage.html',**templateData)

if __name__=="__main__":
    app.run(debug=True,port=4000,host='127.0.0.1')
    
