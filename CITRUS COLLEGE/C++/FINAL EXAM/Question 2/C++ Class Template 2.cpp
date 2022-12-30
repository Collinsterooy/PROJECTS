


#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>
#include <cmath>
#include <ctime>

using namespace std;

const int NumberOfRows = 4; 
const int NumberOfColumns = 4;

class repeatedValue
{
public:
    void randNumGenerator();
    void valueLocator();

private:
    int random[NumberOfRows][NumberOfColumns];
    int valueRow;
    int ValueColumn;
    double valueRepeated;
};

int main()
{
    repeatedValue Array1;

    Array1.randNumGenerator();
    Array1.valueLocator();


    system("pause");
    return 0;
}

void repeatedValue::randNumGenerator() {

    srand(time(0));

    for (int row = 0; row < NumberOfRows; row++) {
        for (int col = 0; col < NumberOfColumns; col++) {
            random[row][col] = (rand() % 10) + 1;
            cout << random[row][col] << "       ";
        }
        cout << endl;
    }
    cout << endl;
}


void repeatedValue::valueLocator() {
    

    for (int i = 1; i <= 10; i++) {
        int counter = 0;
            for (int row = 0; row < NumberOfRows; row++) {
            
                for (int col = 0; col < NumberOfColumns; col++) {
                    if (i == random[row][col]) {

                         counter++;

                    }

                }
           
            }
           if (counter > 1) {
               valueRepeated = i;
               cout << "The index for the repeated value " << valueRepeated << " is: " << endl;
               for (int row = 0; row < NumberOfRows; row++) {

                   for (int col = 0; col < NumberOfColumns; col++) {
                       if (valueRepeated == random[row][col]) {

                           valueRow = row;
                           ValueColumn = col;
                           

                           cout << "(" << valueRow << ", " << ValueColumn << ")" << endl;

                       }

                   }

               }
                
           }
         
    }
    
}