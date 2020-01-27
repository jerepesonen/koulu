def funktio(x,y):
	sum = x + y
	if sum % 2 == 0:
		return("Yes it is!")
	else:
		return("Nope")

x = int(input("Syötä numero: "))
y = int(input("Syötä toinen numero: "))

print(funktio(x,y))

