def calculator(x,y,z):
	if x=='add':
		return(y+z)
	elif x=='sub':
		return(y-z)
	elif x=='multiply':
		return(y*z)
	elif x=='divide':
		try:
			return(y/z)
		except ZeroDivisionError:
			return("None")
print(calculator("add", 1, 2))
print(calculator("sub", 1, 2))
print(calculator("multiply", 1, 2))
print(calculator("divide", 10, 2))
print(calculator("divide", 5, 0))

