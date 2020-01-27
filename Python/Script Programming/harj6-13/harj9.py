def largest(lista):
	i = 0
	for x in lista:
		if x > i:
			i = x
	return(i)

lista=[10,14,34,53,12,567,234,231]
print(largest(lista))
