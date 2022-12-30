#include <iostream>
using namespace std;

int main() {
	//declarations
	int age;

	//get user input
	cout << "Enter your age: ";
	cin >> age;

	//calculation(s)
	age = age * age;
	//output
	cout << "Your value multiplied times itself is " << age <<
		endl;

	return 0;
}

