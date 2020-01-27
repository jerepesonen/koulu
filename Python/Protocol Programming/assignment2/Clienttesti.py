"""Modify the client and server example (from the slides) to work correctly for 
arbitrarily sized messages. This means two things:

Make sure everything gets sent and received
sendall() for sending, looping recv() for receiving
Figure out a way to specify the length of the message to the receiver
sender has to send: length and the contents of the message
receiver has to receive: how many bytes to receive and then call recv() 
as many times as the amount of bytes have been received (loops!)"""

import socket

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect(("localhost", 8888))
msg = str('A'*1000+"\n")
s.sendall(bytes(msg,"utf-8"))

print(str(s.recv(2048), "utf-8"))