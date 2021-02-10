import struct
import os
import argparse
from pathlib import Path
from Crypto.Random import get_random_bytes
from Crypto.Cipher import AES
from Crypto.Util.Padding import pad

parser = argparse.ArgumentParser(description="Choose picture to encrypt")
parser.add_argument("-f", "--file", type=str, help="file to encrypt", default="TUX.bmp")
args = parser.parse_args()

filename = os.path.basename(args.file)
cbcfile = 'CBC_' + filename
ecbfile = 'ECB_' + filename
key = get_random_bytes(16)

bmp = open(args.file, 'rb')
header = bytearray(bmp.read(54))
figure = bytearray(bmp.read())
bmp.close

cbc = AES.new(key, AES.MODE_CBC)
cbc2 = cbc.encrypt(pad(figure, AES.block_size))

file = open(os.path.join('', cbcfile), "wb")
file.write(header)
file.write(cbc2)
file.close()

ecb = AES.new(key, AES.MODE_ECB)
ecb2 = ecb.encrypt(pad(figure, AES.block_size))

file = open(os.path.join('', ecbfile), "wb")
file.write(header)
file.write(ecb2)
file.close()