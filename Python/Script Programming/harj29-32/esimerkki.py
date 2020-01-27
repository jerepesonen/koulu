'''
filu = open('esimerkki.txt', 'w')
filu.write("moi kaikki!\n")
filu.write("adsfweffd\n")
filu.close()
'''

'''
filu = open("esimerkki.txt")
print(filu.read())
'''

#filu = open("esimerkki.txt", "a")
#print(filu.readline())
#print(filu.readline())

#rivit = filu.readlines()
#print(rivit)

#lista = ["asd", "asdfa", "hfw"]
#filu.writelines(lista)
#filu.close()

#for x in range(5):
#	filu.write("\nlisää uusi rivi {}".format(x+1))
#filu.close()

with open("esimerkki.txt") as filu:
	print(filu.read())
