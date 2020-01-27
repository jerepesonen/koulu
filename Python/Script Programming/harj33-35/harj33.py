class Dog:
	def __init__(self, name, sound, walking_speed, running_speed):
		self.name = name
		self.sound = sound
		self.walking_speed = walking_speed
		self.running_speed = running_speed
	def walk(self):
		return ("Dog walks %s km/h" % (self.walking_speed))
	def run(self):
		return ("Dog runs %s km/h" % (self.running_speed))
	def bark(self):
		return ("Dog says %s" % (self.sound))
	def print_name(self):
		return ("Dogs name is %s" % (self.name))

Koira1 = Dog("Sera", "Hau", 6, 25)
Koira2 = Dog("Veeti", "Bow", 5, 23 )

print(Koira1.print_name())
print(Koira1.run())
print(Koira1.bark())
print(Koira1.walk())
print(" ")
print(Koira2.print_name())
print(Koira2.run())
print(Koira2.bark())
print(Koira2.walk())

