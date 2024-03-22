# Defining the function is_divisible(a, b)
def is_divisible(a, b):
	return a % b == 0

# Defining the function is_power(a,b)
def is_power(a, b):
	if a == b: #if the parameter satisfies this condition, it returns true
		return True
	elif b == 1: #if the parameter satisfies this condition, it returns false
		return False
	else:      #if the parameter satisfies both is_divisible and is_power(a/b, b) it returns true. If not, it returns false.
		return is_divisible(a,b) and is_power(a/b, b)
	    
print("is_power(10, 2) returns: ", is_power(10, 2))
print("is_power(27, 3) returns: ", is_power(27, 3))
print("is_power(1, 1) returns: ", is_power(1, 1))
print("is_power(10, 1) returns: ", is_power(10, 1))
print("is_power(3, 3) returns: ", is_power(3, 3))
