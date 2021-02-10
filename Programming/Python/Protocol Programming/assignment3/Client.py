"""	Make the following modifications to the client program:

	Add two command line parameters to the program:
	address
	port
	If these two values are not given from the command line the client should print an error message and exit immediately
	
	Handle the exceptions from connect() and send() and print a human readable error message if an error occurs.
	e.g. cannot connect to server or sending data to server failed
	
	Hint: argparse module from the standard library makes handling command line parameters easier. In a simple example like this, it is a bit of an overkill,
	but it is extremely useful to be familiar with it. You can also use sys.argv if you want.

© Copyright 2019 Marko Silokunnas"""

import socket
import sys
import argparse

parser = argparse.ArgumentParser(description="Connect to server!")
parser.add_argument("-a", "--host", type=str, help="Ip address to connect")
parser.add_argument("-p", "--port", type=int, help="Port to connect")
args = parser.parse_args()

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
try:
	s.connect((args.host, args.port))
except:
	print("Cannot connect to server!")
try:
	s.sendall(bytes("Hello World1!\n", "utf-8"))
except:
	print("Sending data to server failed!")
print(str(s.recv(1024), "utf-8"))
s.close()