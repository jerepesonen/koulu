def vowels(char):
	vokaalilaskuri= 0
	for x in char:
		if x in "aeiouyAEIOUY":
			vokaalilaskuri += 1
	return vokaalilaskuri

print(vowels('qwertyuiopökjhgfdsazxcvbnmkjhgfsertyu'))
