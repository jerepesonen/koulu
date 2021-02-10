def compareNumbers(x,y):
	if x > y:
		return(x)
	else:
		return(y)

x = int(input("Syötä numero: "))
y = int(input("Syötä toinen numero: "))

print(compareNumbers(x,y))
