alphabet =  "abcdefghijklmnopqrstuvwxyz"
test_dups = ["zzz","dog","bookkeeper","subdermatoglyphic","subdermatoglyphics"]
test_miss = ["zzz","subdermatoglyphic","the quick brown fox jumps over the lazy dog"]

def histogram(s):                  #defining the histogram funcion
	d = dict()
	for c in s:
		if c not in d:
			d[c] = 1
		else:
			d[c] += 1
	return d

def has_duplicates(s):          #defining the has_duplicates function
	h = histogram(s)
	t = h.items()
	for key, value in t:
		if value > 1:
			return True
	return False

for c in test_dups:                            #loop to print the statment for each string
	ans = has_duplicates(c)
	if ans == True:
		print(str(c) + ' has a duplicates')
	elif ans == False:
		print(str(c) + ' has no duplicates')

print('')  #printing new line
		
		
		
def missing_letters(s):           #efining the missing_letters function
	global alphabet
	h = histogram(alphabet)
	New_list = []
	t = h.items()
	for key, value in t:
		if key not in s:
			New_list += key
	delimiter = ' '                     #joingin the element of the list New_list
	J = delimiter.join(New_list)
	return J

for A in test_miss:                             #loop to print the statement for each string
	ans = missing_letters(A)
	if len(ans):
		print(str(A) + ' is missing letters ' + ans)
		
	else:
		print(str(A) + ' used all the letters')
