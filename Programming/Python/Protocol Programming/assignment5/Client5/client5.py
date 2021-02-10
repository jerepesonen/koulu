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

parser = argparse.ArgumentParser(description="Send file to the server!")
parser.add_argument("-f", "--path", help="path to save file", default="files/")
parser.add_argument("-a", "--host", type=str, help="Ip address to connect", default="localhost")
parser.add_argument("-p", "--port", type=int, help="Port to connect", default="8888")
args = parser.parse_args()

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
	s.connect((args.host, args.port))
	while True:
		try:
			x = int(input("If you want to LIST files, type: 1\nIf you want to DOWNLOAD a file, type: 2\n"))
		except ValueError:
			print("Enter valid choice!")
		if x == 1:
			s.sendall(bytes("LIST", "utf-8"))
			list = str(s.recv(4096), "utf-8")
			print(list)
			continue
		elif x == 2:
			s.sendall(bytes("DOWNLOAD", "utf-8"))
			filename = str(input(str(s.recv(4096), "utf-8")))
			
			s.sendall(bytes(filename, "utf-8"))
			data = s.recv(4096)
			strdata = str(data, "utf-8")
			if strdata == "error":
				print(str(s.recv(4096), "utf-8"))
			else:
				file = open(os.path.join(args.path, filename), "wb")
				file.write(data)
				file.close
				print("File %s downloaded!"  % filename)
			break
		else:
			print("Something went wrong, try again")
			continue
		