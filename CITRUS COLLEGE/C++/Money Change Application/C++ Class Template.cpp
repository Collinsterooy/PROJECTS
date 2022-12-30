


#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>
#include <cmath>

using namespace std;

const int HALF_A_DOLLAR = 50;
const int QUARTERS = 25;
const int DIME = 10;
const int NICKEL = 5;

int main()
{
    //declarations
    int cents, halfDollar, quaters, dime, nickel, penny, change;



    //get user input
    cout << "Enter the amount of Cents you have: ";
    cin >> cents;
    cout << endl;

    //calculation 
    halfDollar = cents / HALF_A_DOLLAR;
    change = cents %  HALF_A_DOLLAR;

    quaters = change / QUARTERS;
    change = change % QUARTERS;

    dime = change / DIME;
    change = change % DIME;

    nickel = change / NICKEL;
    change = change % NICKEL;

    penny = change;



    //Output
    cout << endl;
    cout << "You have: " << halfDollar << " half dollars, " << quaters << " quaters, " << dime << " dimes, " << nickel << " nickel, " << "and " << penny << " pennies" << endl;


    system("pause");
    return 0;
}

