


#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>
#include <cmath>

using namespace std;

//Named Constants

const int INT_PER_FOOT = 12;
const double CENTEMETER_PER_INCH = 2.54;

int main()
{
    //declarations

    int feet, inches;
    int totalInches;
    double centemeters; 


    //get user input

    cout << "Enter two integers, one for feet, and one for inches: ";

    cin >> feet >> inches;



    //calculation 

    totalInches = (INT_PER_FOOT * feet) + inches;

    centemeters = totalInches * CENTEMETER_PER_INCH;


    //Output

    cout << feet << " feet " << inches << " inches" << " is equals to " << centemeters << " centimeters" << endl;


    system("pause");
    return 0;
}

