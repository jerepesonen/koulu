def speeding_ticket(nopeus, rajoitus):
	if (rajoitus*1.2) < nopeus:
		return(int(500), bool(1))
	elif (rajoitus*1.05) < nopeus:
		return(int(100),bool(0))
	else:
		return(int(0), bool(0))
print(speeding_ticket(50,50))
print(speeding_ticket(60,50))
print(speeding_ticket(100,50))
