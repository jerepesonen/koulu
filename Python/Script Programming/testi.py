'''
def lisaa(x,y):
	return x+y

uusi_muuttuja = lisaa

print(uusi_muuttuja(5,5))

lista = [uusi_muuttuja,range]
print(lista)

print(lista[0](4,4))


def lisaa(x):
	return x*2

lista = [1,2,3,4,5,6,7,8,9]
tulos = map(lisaa, lista)

for x in tulos:
	print(x)

lista_tulos = list(tulos)
print(lista_tulos)
'''
'''
def plus(x,y):
	return x+y

lista1 = [1,2,3]
lista2 = [5,6,7]

tulos = list(map(plus,lista1,lista2))
for x in tulos:
	print(x)
'''
'''
def jakojaannos(x):
	return x%2==0

lista = [1,2,3,4,5,6,7,8,9]

#filter(funkrio,sekvenssi)

tulos = filter(jakojaannos, lista)

kastattu_tulos = list(tulos)

print(kastattu_tulos)

for x in tulos:
	print(x)
'''
'''
kirjaimet = ['a','b','c','d','e','f','g','h','i',]

def tarkista(lista):
	vokaalit = ['a','e','i','o','u','y']
	if lista in vokaalit:
		return True
	else:
		return False

tulos = filter(tarkista,kirjaimet)

for x in tulos:
	print(x)
'''
'''
lista = [0,'0',False,True,123,'moimoi']

tulos = filter(None, lista)

for x in tulos:
	print(x)
'''
'''
muuttuja = lambda x: x+1

print(muuttuja(5))

sikapossu = muuttuja

print(sikapossu(2))
'''
'''
sika = lambda x: x>10

print(sika(1))
print(sika(55))
'''
'''
possu = lambda x,y: x+y

print(possu(1,2))
'''
'''
maara = int(input("Anna luku"))

potenssilista = list(map(lambda x: 2 ** x, range(maara)))

print(potenssilista)
'''

def moi(x):
	return x

sikapossu = moi

print(sikapossu("moi kaikki"))

funktiolista = [sikapossu]

print(funktiolista[0]("Tulostin tämän listalta"))

