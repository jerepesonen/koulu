import binascii

string1 = str(input("insert ciphertext for bruteforce: "))
string2 = str(input("insert keyword for bruteforce (optional): "))
scale= 16

bytearray1= bytearray(string1, "utf8")
bytearray2 = bytearray(string2, "utf8")
bin1 = bin(int(string1, scale)).zfill(8)
bin2 = bin(int(string2, scale)).zfill(8)

#print(bin(bin1 ^ bin2))
#print(binary_string)

byte_list1 = []
byte_list2 = []
byte_list3 = []
for byte in bytearray1:
    binary_representation = bin(byte)
    byte_list1.append(binary_representation)
    
for byte in bytearray2:
    binary_representation = bin(byte)
    byte_list2.append(binary_representation)

for x in range(0, len(byte_list1)):
    byte_list3.append(bin(byte_list1[x] ^ byte_list2[x]))

print(byte_list3)
print(bytearray1)