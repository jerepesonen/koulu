import socket

sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
def	funktio(socket, data):
	try:
		sock.connect((socket))
		sock.sendall(bytes(data, "utf-8"))
		print(str(sock.recv(1024), "utf-8"))
	except ConnectionRefusedError:
		print("Could not connect to server!")
		
socket = ("localhost", 8888)
data = ("Hello world!")

funktio(socket, data)
	
	
