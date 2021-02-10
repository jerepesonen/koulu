animals = open('animals.txt', 'r')
lista = animals.read().splitlines()
print(sorted(lista))
animals.close
