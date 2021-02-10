import socket
	
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
sock.bind(("localhost", 8888))
sock.listen(5)
(client, addr) = sock.accept()
print("Received connection from", addr)
print(str(client.recv(1024), "utf-8"))
client.send(bytes("Message received!", "utf-8"))