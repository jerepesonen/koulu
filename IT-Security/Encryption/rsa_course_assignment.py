import secrets
import math


def generatePrime():# generoidaan alkuluku
    x = False
    while x == False: # silmukka pyörii, kunnes luku on alkuluku, ja x == True 
        luku = secrets.SystemRandom().randint(3,10*10**4) # luodaan satunnainen luku
        x = checkPrime(luku) # Funktio checkPrime tarkistaa onko luku alkuluku
    return(luku)

def checkPrime(luku):
    n2 = math.ceil(math.sqrt(luku)) # luvun neliöjuuri
    if luku % 2 == 0: # jos luku on jaollinen kahdella, se ei ole alkuluku
        return False
    for i in range (3, n2+1, 2): # lasketaan jakojäännös kolmosesta etenpäin kahden luvun välein
        if luku % i == 0: # jos luku on jaollinen jollain näistä, se ei ole alkuluku
            return False
    return True
   
def gcd(x, y): # laskentaan x:n ja y:n suurin yhteinen tekijä eukleiden algoritmilla 
    if(y>x): # jos y on isompi kuin x, vaihdetaan niiden järjestystä
        apu = x
        x=y
        y=apu
    while(y != 0): # silmukka pyörii, kunnes jakojäännös on 0
        mod = x%y # x:n ja y:n jakojäännös
        x = y # asetetaan x:n paikalle y
        y = mod # asetetaan y:n paikalle x:n ja y:n jakojäännös 
    return x # palautetaan x, eli viimeinen jakojäännös ennen nollaa


def egcd(e, et):
    a = 0
    a2 = 1
    et2 = et
    while e != 0:
        luku = et // e # et ja e osamäärä pyöristettynä alaspäin
        apu = a
        a = a2
        a2 = apu - luku * a2 # kerroin löytyy täältä
        
        apu2 = et
        et = e
        e = apu2 - luku * et
    
    if et > 1:
        return 1
    if a < 0:
        a = a + et2
    return a

def encryption(e,n,string):
    cipher = pow(string, e, n) # python funktion pow laskee string**e%n
    print('\nEncryption: message^e (mod n)')
    print("%i ^ %i mod(%i) = %i" % (string, e , n, cipher))
    return cipher

def decryption(d,n,cipher):
    decrypt = pow(cipher, d, n)# python funktion pow laskee cipher**e%n
    print('\nDecryption: cipher^d (mod n)')
    print("%i ^ %i mod(%i) = %i" % (cipher, d , n, decrypt))
    return int_to_bytes(decrypt)


def broadcastAttack(ciphers, keys):
    c0, c1, c2 = ciphers[0], ciphers[1], ciphers[2] # Encryptatut tekstit
    n0, n1, n2 = keys[0], keys[1], keys[2] # cryptauksia vastaavat n arvot
    ms0, ms1, ms2 = n1*n2, n0*n2, n0*n1 # kerrotaan m arvot keskenään, ja tallennetaan ne muuttujiin.

    #broadcast attack crt:tä käyttäen
    result = ((c0 * ms0 * egcd(ms0, n0)) + (c1 * ms1 * egcd(ms1, n1)) + (c2 * ms2 * egcd(ms2, n2))) % (n0*n1*n2)
    return cuberoot(result)

def cuberoot(n):
    left = 0
    right = n
    while left < right:
        half = (left + right) // 2
        if half**3 < n:
            left = half + 1
        else:
            right = half

    return left

def main():
    e = 3
    message = 5000
    ciphers = []
    keys = []
    
    for k in range(3):
        d = 1
        while (d < 4 or p == q or gcd(et,e) != 1): 
            p = generatePrime() # generoidaan alkuluvut p ja q.
            q = generatePrime()
            n = p*q # lasketaan n.
            et = (p-1)*(q-1) # lasketaan et = kuinka monta alkulukua 1<et<n.
            d = egcd(e,et) # lasketaan salainen avain d Eucledian algoritmilla.
        cipher = encryption(e,n,message)
        ciphers.append(cipher)
        keys.append(n)
    print("\nciphers: ", ciphers)
    print("public keys: ", keys)
    result = broadcastAttack(ciphers, keys)
    print("\nresult: ",result)
main()