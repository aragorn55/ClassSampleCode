#include <conio.h>
#include <iomanip>
#include <iostream>
#include <string>
#include "..\..\HelperClass\HelperClass\HelperBot.h"

using namespace std;
double calculateWage(double hours_worked);
int main()
{

	double hours_worked = 0;
	
		bool quit = false;
	//loop until a non negative number is entered
	while (!quit)
	{
	cout << "Please enter the number of hours worked:";
	cin >> hours_worked;
	
		if (hours_worked < 0)
	{
		cout << endl << "Please enter a non negative number" << endl ;
	}
	else
	{
		quit = true;
	}
	}
	cout << setprecision(2) << fixed  <<"you made $" << calculateWage(hours_worked) << " dollars this week" << endl;

	_getch();
	return 1;

}
double calculateWage(double hours_worked)
{
		double salary = 0;
		//check hours worked is greater than 40
	if (hours_worked >= 40)
	{
		// if greater then 40, salary = the hrs over 40 *12 + 40 hrs * 8 
		salary = (40 * 8.00) + ((hours_worked - 40) * 12.00);
	}
	else
	{
		// if not  greater then 40, salary = the hrs  * 8 
		salary = (hours_worked * 8.00);
	}
	return salary;


}