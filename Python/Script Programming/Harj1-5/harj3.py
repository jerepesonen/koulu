luku = 2
lkm = luku
vali = 9
kirjain="A"
while luku < 20:
	while lkm > 0:
		while vali > 0:
			print(" ", end = '')
			vali = vali-1
		print(kirjain, end = '')
		lkm -= 1
	print("")
	luku += 2
	lkm = luku
	vali =10-luku/2

