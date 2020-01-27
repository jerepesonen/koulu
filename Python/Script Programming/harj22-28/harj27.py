import random

x = random.randint(0,20)
y = int(1)
print("++ Guessing Game xx\nGuess a number between 0 and 20 !")
while y < 6:
	while True:
		try:
			z = (int(input("Guess %s/5: "%(y))))
			if z >= 0 and z <= 20:
				break
			else:
				print("The guess should be between 0 and 20, tryagain")
				continue
		except ValueError:
			print("Not a number, try again")
	if z == x:
		print("Correct!")
		break
	else:
		if y == 5:
			print("Game over, you lost! the correct number was", x)
		else:
			print("Sorry, try again!")
	y = y+1
