import codecs

string1 = str(input('Give first string: '))
key = "ICE"
num = 0
result = "0"
#while len(string1) > len(key):
#    key = key + key
for x in string1:
    apu = x.encode('utf-8').hex()
    key2 = key[num].encode('utf-8').hex()
    result = result + (hex(int(apu, 16) ^ int(key2, 16))).strip('0x')
    num += 1
    if (num == 3):
        num = 0
    
print(result)