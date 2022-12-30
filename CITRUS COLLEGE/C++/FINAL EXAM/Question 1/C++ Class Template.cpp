


#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>
#include <cmath>

using namespace std;

int count(string input, int& NoOfLetters, int& NoOfNumbers);


string userInput;
int letterNumbers = 0;
int NumberNumbers = 0;
string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
string number = "0123456789";





int main()
{

    cout << "enter a string: ";
    getline(cin, userInput);
    cout << endl;

    count(userInput, letterNumbers, NumberNumbers);
 
    cout << " The number of Letters  in " << '\"' << userInput << '\"' << " is " << letterNumbers << endl << endl;
    cout << " The number of Numbers in " << '\"' << userInput << '\"' << " is " << NumberNumbers << endl << endl;



    system("pause");
    return 0;
}


int count(string input, int& NoOfLetters, int& NoOfNumbers) {

    int inputSize = userInput.length();
   
    for (int i = 0; i <= inputSize; i++) {

        if (alphabet.find(input[i]) != string::npos) {
            NoOfLetters++;
        }
        else if(number.find(input[i]) != string::npos) {
            NoOfNumbers++;
        }
    }
    return NoOfLetters, NoOfNumbers;
}


