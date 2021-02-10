string1 = str(input('Give first string: '))
string2 = str(input('Give second string: '))

print(hex(int(string1, 16) ^ int(string2, 16)))