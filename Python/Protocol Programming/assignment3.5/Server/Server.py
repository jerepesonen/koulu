"""

Write a client and a server program that can be used to send files to the server. You have to come up with a simple protocol (you don’t have to document the protocol, but you can) which allows the transfer of files. The protocol should be able to transmit name, size and contents of the file being sent. It is up to you to implmement this. The client HAS to send this information:

name of the file
size of the file (in bytes!)
contents of the file (actual bytes of the file from disk)
When the server receives the connection, it uses this information to:

create a new file with the same name
receive the total size of the file to receive (in bytes)
Receive the contents of the file and write them to a file on disk.
under the received files directory.
name of the file has to be same as the one that the client sent
Start early so you can ask questions from the lecturer!

Client
The client takes three command line parameters:

path of the file to send
server address
server port
The client will print an error message and exits if any of the following conditions are met:

The file is missing
The file cannot be read from
The client cannot connect to the server
any others that you can think of
Server
The server takes three command line arguments:

path to a folder where to store the received files
server address
server port
Once started, the server will listen for clients and receive files from the clients one by one. Each time a file is received the name of that file should be printed.

The server will print an error message and exits if any of the following conditions are met:

The target folder doesn’t exist
Receiving a file failed
Any other that you can think of
Example
Server has been started with the following arguments (you can use the same command line argument names if you want):

receive-directory: received-files\ (the directory is empty when the server is started for the first time)
bind-addr: localhost
bind-port: 8888
Client is used with the following arguments (you can use the same command line argument names if you want):

file-to-send: house.jpg
server-addr: localhost
server-port: 8888
After the client has finished, the server has house.jpg under received-files directory (received-files\house.jpg)

"""

import socket
import argparse
import os
from pathlib import Path

#Example parameters: Server.py -a localhost -p 8888 -f received_files/

parser = argparse.ArgumentParser(description="Put up a server")
parser.add_argument("-f", "--path", help="path to a folder where to store the received files")
parser.add_argument("-a", "--host", type=str, help="Server address")
parser.add_argument("-p", "--port", type=int, help="Server port")
args = parser.parse_args()

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
	try:
		s.bind((args.host, args.port))
		s.listen(5)
		
		print("Waiting for connection!\n")
		(client, addr) = s.accept()
		
		info = str(client.recv(4096), "utf-8")
		filename = info.split("\n")[1]
		size = int(info.split("\n")[0])
		client.send(bytes("Header received!\n", "utf-8"))
		
		data = (client.recv(4096))
		received = len(data)
		
		while received < size:
			data = data+client.recv(4096)
			received = len(data)
		
		file = open(os.path.join(args.path, filename), "wb")
		file.write(data)
		file.close()
		client.send(bytes("File received!\n", "utf-8"))
		print("Received file!\n")
	except FileNotFoundError:
		print("Folder not found!")
	except IndexError:
		print("Receiving file failed!")
	except:
		print("Error")