#bruteforce ceasar cipher

alp = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
alp2 = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']

string = str(input("insert ciphertext for bruteforce: "))
keyword = str(input("insert keyword for bruteforce (optional): "))
answers = ""
def bruteforce(string, keyword):
    for z in range(len(alp)):
        cipher = ""
        for x in string:
            for y in range(len(alp)):
                if x == alp[y]:
                    cipher = cipher + (alp[(y + z) % 26])
                    break
                elif x == alp2[y]:
                    cipher = cipher + (alp2[(y + z) % 26])
                    break
                elif y == len(alp)-1:
                    cipher = cipher + x
        if keyword.upper() in cipher.upper():
            print("Key %s Decryption = %s" % (str(z), cipher))

bruteforce(string, keyword)
