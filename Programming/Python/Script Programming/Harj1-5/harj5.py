lista = ['1','2','3','4','5']

x = 1

print("lista",lista)

while x != 10:

	x = int(input("Jos haluat lis�t� listaan luvun, sy�t� 1, jos haluat poistaa luvun, sy�t� 0. Jos haluat lopettaa, sy�t� 10\n"))

	if x > 0 and x < 10:

		x = lista.append(input("Anna Luku jonka haluat lis�t� listaan: \n"))

	elif x > 9:

		continue

	else:

		x = lista.remove(input("Anna Luku jonka haluat poistaa listasta: \n"))

print(lista)