animals = open('animals.txt', 'r')
lista = animals.read().splitlines()
print(sorted(lista))
animals.close

lista.append(input("Lisää eläin: "))

animals = open('animals.txt', 'w')
for x in lista:
	animals.write("%s\n" % x)
print(sorted(lista))
animals.close
