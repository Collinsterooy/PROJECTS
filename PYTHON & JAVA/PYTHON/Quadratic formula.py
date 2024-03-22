import math
def Quadratic_Formula(a, b, c):
	if b**2 < 4 * a * c:
		print("enter a bigger number for 'b'")
	else:
		B = - b
		Bsqr = b**2
		Four_A_C = 4 * a * c
		Denom = 2 * a
		SqrtFour_A_C = math.sqrt(Bsqr - Four_A_C)
		Xone = (B + SqrtFour_A_C) / Denom
		Xtwo = (B - SqrtFour_A_C) / Denom
		Answer = 'The roots of the equation are ' + str(Xone) + ' and ' + str(Xtwo)
		print(Answer)
		return(Answer)

Quadratic_Formula(1, 4, 4)
Quadratic_Formula(5, 3, 3)
