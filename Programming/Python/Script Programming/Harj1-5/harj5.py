lista = ['1','2','3','4','5']

x = 1

print("lista",lista)

while x != 10:

	x = int(input("Jos haluat lisätä listaan luvun, syötä 1, jos haluat poistaa luvun, syötä 0. Jos haluat lopettaa, syötä 10\n"))

	if x > 0 and x < 10:

		x = lista.append(input("Anna Luku jonka haluat lisätä listaan: \n"))

	elif x > 9:

		continue

	else:

		x = lista.remove(input("Anna Luku jonka haluat poistaa listasta: \n"))

print(lista)