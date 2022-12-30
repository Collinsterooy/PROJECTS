import math
def my_sqrt(a):
	x = 3
	while True:
		y = (x + a/x) / 2
		if y == x:
			return y
		x = y

def test_sqrt():
	a = 1
	while a < 26:
		print('a = ' + str(a) + ' | my_sqrt(a) = ' + str(my_sqrt(a)) + ' | math.sqrt(a) = ' + str(math.sqrt(a)) + ' | diff = ' + str(abs(my_sqrt(a) - math.sqrt(a))))
		a = a + 1
test_sqrt()
