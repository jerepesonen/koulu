def sum2(x):
	e=0
	while x != 0:
		e = e + x
		x = x-1
	return e

x= int(input("Anna Luku: "))
print(sum2(x))
