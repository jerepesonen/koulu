#Peräkkäishaku
# tuodaan random ja time paketit
import random 
import time
lista = [] # alustetaan lista

for x in range(0,100000001):
    lista.append(x) # lisätään listaan haluttu määrä lukuja nollasta eteenpäin
    
def Peräkkäis(lista = []): # luodaan funktio, joka toteuttaa peräkkäishaun
    etsi = len(lista) -1 # asetetaan etsittäväksi luvuksi listan viimeinen luku
    for i in range (len(lista)): # for silmukka, jossa käydään listan alkiot yksi kerrallaan läpi
        if lista[i] == etsi: # verrataan i:n arvoa etsittävän numeron arvoon
            return("Hakemasi numero löytyi muistipaikalta: "
            + str(i)) # jos etsittävä numero löytyy, palautetaan muistipaikan numero
            break;# silmukka keskeytetään
    return("Hakemaasi numeroa ei löytynyt") # jos lista käydään kokonaan läpi, eikä etsittävää numeroa löydy, palautetaan ilmoitus


start = time.time() # aloitetaan kellotus
print(Peräkkäis(lista))# kutsutaan Peräkkäis funktiota lista parametrillä
end = time.time() # pysäytetään kellotus

print("Hakuun kului aikaa", end-start, "sekuntia") # tulostetaan hakuun kulunut aika