print("calling Nine line() function")

#defining the function new_line
def new_line():
    print('.')

#defining the function three_line
def three_lines():
    new_line()
    new_line()
    new_line()

#defining the function nine_line
def nine_lines():
    three_lines()
    three_lines()
    three_lines()


#defining the function clear_screen
def clear_screen():
    new_line()
    three_lines()
    three_lines()
    nine_lines()
    nine_lines()

#calling the nine_lines() function
nine_lines()

print("Calling clear_screen() function")

#calling the clear_screen() function
clear_screen()
