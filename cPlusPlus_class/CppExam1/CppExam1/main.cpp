#include <conio.h>
#include <iostream>
#include <iomanip>
using namespace std;
int main()
{
	
	float milesDriven; // the miles driven
	float gallonsUsed; //  the gallons of gas used
	float mPG; // the Miles Per Gallon achived
	// send request for the miles driven
	cout << "Enter the miles driven: ";
	// grab user input
	cin >> milesDriven;
	cout << endl;
	// send request fo the gallons of gas used
	cout << "Enter the gallons of gas used: ";
		// grab user input
	cin >> gallonsUsed;
	cout << endl;
	// calculate miles per gallon = (miles driven / gallons of gas used)
	mPG = milesDriven / gallonsUsed;
	// send out put of MPG with a single decimal place of percision
	cout << "Miles Per Gallon: " << setprecision(1) << fixed << mPG << endl;
	

	
	_getch();
}
