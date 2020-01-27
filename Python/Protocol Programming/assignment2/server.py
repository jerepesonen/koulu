"""Modify the client and server example (from the slides) to work correctly for 
arbitrarily sized messages. This means two things:

Make sure everything gets sent and received
sendall() for sending, looping recv() for receiving
Figure out a way to specify the length of the message to the receiver
sender has to send: length and the contents of the message
receiver has to receive: how many bytes to receive and then call recv() 
as many times as the amount of bytes have been received (loops!)"""

import socket
	
def main():
	s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
	s.bind(("localhost", 8888))
	s.listen(5)
	print("Server running")	
	(client, addr) = s.accept()
	print("Received connection from:", addr)
	
	msg = str(client.recv(1024), "utf-8")
	
	header = int(msg.split("\n")[0])
	fullmsg = msg.split("\n")[1]
	received = len(fullmsg)
	
	while received < header:
		fullmsg = fullmsg+str(client.recv(1024), "utf-8")
		received = received+len(msg.split("\n")[1])
		
	print(fullmsg, "\n", len(fullmsg))
	client.send(bytes("Message received!\n", "utf-8"))
	
if __name__ == "__main__":
    main()