#include <iomanip>
#include <iostream>
#include <string>


using namespace std;


int main() {

	//double x = 462.191;
	//double y = 794.579;
	//double z = 32.1238;

	cout << "123456789012345678901234567890" << endl;	
		cout << setfill('#') << setw(10) << "Mickey"
		<< setfill(' ') << setw(10) << "Donald"
		<< setfill('*') << setw(10) << "Goofy" << endl;


	return 0;
}