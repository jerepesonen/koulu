"""Modify the client and server example (from the slides) to work correctly for 
arbitrarily sized messages. This means two things:

Make sure everything gets sent and received
sendall() for sending, looping recv() for receiving
Figure out a way to specify the length of the message to the receiver
sender has to send: length and the contents of the message
receiver has to receive: how many bytes to receive and then call recv() 
as many times as the amount of bytes have been received (loops!)"""

import socket
	
i = 1
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.bind(("localhost", 8888))
s.listen(1)
print("servu pyörii")
(client, addr) = s.accept()
print("Received connection from ", addr)
msg = str("")
while i == 1:
	if "\n" in msg:
		i = 2
		break
	msg = msg+str(client.recv(2048), "utf-8")
print(msg,len(msg)-1)	
client.send(bytes("Message received!\n", "utf-8"))
