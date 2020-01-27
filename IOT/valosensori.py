import serial

arduino = serial.Serial('COM3', 9600, timeout=.1)

while True:
	data = arduino.readline()[:-2] #the last bit gets rid of the new-line chars
	if data:
		with open("data.txt","a") as file:
			file.write(data)
		print data
