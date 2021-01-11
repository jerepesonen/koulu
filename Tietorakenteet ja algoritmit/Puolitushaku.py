# Puolitushaku
# tuodaan random ja time paketit
import random
import time
lista = [] # alustetaan lista

for x in range(0,10001):
    lista.append(x) # lisätään listaan haluttu määrä lukuja nollasta eteenpäin
    
def Puolitus(lista = []): # luodaan funktio, joka toteuttaa puolitushaun
    etsi = len(lista)-1 # asetetaan etsittäväksi luvuksi listan viimeinen luku
    print(etsi) # tulostetaan luku
    L = lista[0] # alustetaan muuttujaksi L, listan ensimmäisen alkion luku
    R = lista[-1]# alustetaan muuttujaksi R, listan viimeisen alkion luku

    while (L <= R): # while silmukka, joka pyörii niin kauan, kun L on pienempi tai yhtäsuuri, kuin R
        if(lista[int((L+R)/2)] == etsi): # if lause vertaa, että onko löytyykö listan muistipaikasta L+R/2, etsitty luku.
            return("Luku löytyy muistipaikasta: " + str(int((L+R)/2)))# jos löytyy palautetaan kyseinen muistipaikka
        elif(etsi > int((L+R)/2)): # if lause tutkii, onko etsitty luku isompi, kuin listan keskimmäinen luku
            L = int((L+R)/2) + 1 # jos on asetetaan L muuttujaksi listan keskimmäinen luku, ja listan lukujen määrä puolittuu
            #print(L)
        else: # viimeisessä vaihtoehdossa etsitty luku on pienempi, kuin listan keskimmäinen luku
            R = int((L+R)/2) # jos on asetetaan R muuttujaksi listan keskimmäinen luku, ja listan lukujen määrä puolittuu
            #print(R)
    return("Hakemaasi numeroa ei löytynyt") # jos while silmukka pääsee loppuun asti, palautetaa, että etsittyä lukua ei löytynyt

start = time.time()# aloitetaan kellotus
print(Puolitus(lista))# kutsutaan Puolitus funktiota lista parametrillä
end = time.time()# pysäytetään kellotus
print("aikaa kului", end-start, "sekuntia") # tulostetaan hakuun kulunut aika
