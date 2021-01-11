#Encrypt with ceasar cipher

alp = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
alp2 = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']

key = int(input("insert key for caesar decryption: "))
string = str(input("insert cyphertext to decrypt: "))

def encrypt(key, string):
    cipher = ""
    for x in string:
        for y in range(len(alp)):
            if x == alp[y]:
                cipher = cipher + (alp[(y - key) % 26])
                break
            elif x == alp2[y]:
                cipher = cipher + (alp2[(y - key) % 26])
                break
            elif y == len(alp)-1:
                cipher = cipher + x
    return(cipher)

print("Plaintext = " +  encrypt(key, string))