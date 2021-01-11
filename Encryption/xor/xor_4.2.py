from langdetect import detect

string1 = str(input('Give first string: '))
string2 = ""
for x in range(0, 256):
    string2 = ""
    for y in range(len(string1)//2):
        string2 = string2 + str(x)
    #string2 = string2.encode("utf-8").hex()
    string3 = hex(int(string1, 16) ^ int(string2, 16))
    string3 = string3.split('x')[1]
    try:
        string4 = bytearray.fromhex(string3).decode()
        lang = detect(string4)
        if lang == 'en':
            print(string4)
    except:
        continue