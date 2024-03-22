#defining the function that counts down an integer
def countdown(Number):
	if Number > 0:
		print(Number)
		countdown(Number - 1)
	else:
		print('Are you ready?')
		
#defining the function that counts up an integer
def countup(Number):
	if Number <= 0:
		print(Number)
		countup(Number + 1)
	else:
		print('Are you ready?')

#defining the function that counts up or down an integer
def lets_go():
	Number = int(input('Enter a number\n'))
	if Number > 0:
		countdown(Number)
	else:
		countup(Number)
		
#calling the function
lets_go()
