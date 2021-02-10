"""
Design a simple file transfer protocol.

The protocol client has to have at least two possible request

LIST which lists the filenames of the files available on the server.
DOWNLOAD which downloads a file. A filename has to be provided.
The protocol server has to have at least two possible responses:

ERROR which tells the client that the request could not be processed. The error message can be describe several different kinds of errors.
FILE which returns the data to the client.
"""

import socket
import argparse
import os
from pathlib import Path

parser = argparse.ArgumentParser(description="Put up a server")
parser.add_argument("-f", "--path", help="path to a folder where to store the received files", default="files/")
parser.add_argument("-a", "--host", type=str, help="Server address", default="localhost")
parser.add_argument("-p", "--port", type=int, help="Server port", default="8888")
args = parser.parse_args()

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
	s.bind((args.host, args.port))
	s.listen(5)
	
	print("Waiting for connection!\n")
	(client, addr) = s.accept()
	while True:
		arg = str(client.recv(4096), "utf-8")
		if arg == "LIST":
			list = str(os.listdir(args.path))
			client.send(bytes(list, "utf-8"))
		elif arg == "DOWNLOAD":
			client.send(bytes("Name the file you would like to download: ", "utf-8"))
			filename = (str(client.recv(4096), "utf-8"))
			try:
				filetosend = open(Path(args.path, filename), "rb").read()
				client.sendall(filetosend)
			except FileNotFoundError:
				client.send(bytes("error", "utf-8"))
				client.send(bytes("File not found!", "utf-8"))
				
			break
		else:
			break