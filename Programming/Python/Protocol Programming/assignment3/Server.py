"""	Make the following modifications to the server example:

	Add two command line parameters to the program
	If these two values are not given from the command line the server should print an error message and exit immediately
	These two values should be used for binding the server socket with bind()
	Keep the server running after a single connection has been handled
	You don’t have to be able to handle multiple connections at the same time
	Once a connection has been handled, the server should go back to waiting on accept()

© Copyright 2019 Marko Silokunnas"""

import socket
import sys

def main():
	sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
	try:
		host = input("Enter address: ")
		port = int(input("Enter port number: "))
	except ValueError:
		print("\n Error")
		raise SystemExit
	print(host, port)
	sock.bind((host, port))
	sock.listen(1)
	while True:
		print("Waiting for connection\n")
		(client, addr) = sock.accept()
		print("Received a connection from ", addr, "\n")
		while True:
			data = str(client.recv(1024), "utf-8")
			if not data:
				break
			else:
				print(data)
			client.send(bytes("Hello Hello!\n", "utf-8"))

if __name__ == "__main__":
    main()