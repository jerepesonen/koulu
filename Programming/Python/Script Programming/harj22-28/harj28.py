import sys

print("++ Calculator ++")
print("0)  add\n1)  sub\n2)  multiply\n3)  divide\n-1) quit\n")
while True:
	try:
		choice = input("Choice:")
		if choice == '-1':
			sys.exit()
		num1 = int(input("First number: "))
		num2 = int(input("Second number: "))
	except ValueError:
		print("try again!")
	if choice == '0':
		print(num1 + num2)
	elif choice == '1':
		print(num1 - num2)
	elif choice == '2':
		print(num1 * num2)
	elif choice == '3':
		try:
			print(num1 / num2)
		except ZeroDivisionError:
			print("Can't devide by zero!")
