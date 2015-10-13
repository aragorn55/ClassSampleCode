#include <conio.h>
#include <iostream>
#include <string>
#include <iomanip>
#include "../../HelperClass/HelperClass/HelperBot.h"

using namespace std;
double Sum(double, double, double);
int main()
{
	double value_one = 0;
	double value_two = 0;
	double value_three = 0;
	string input = "";
	bool keep_looping = true;
	
	while (keep_looping)
	{
		cout << "Press enter a number:";
		cin >> input;
	if (HelperBot::IsNumeric(input))
	{
		keep_looping = false;
		value_one = HelperBot::ConvertToDouble(input);
		cout << endl;

	}
	else
	{
		cout << endl << "Sorry not a Number!" << endl;
	}
	}
	keep_looping = true;
	
	while (keep_looping)
	{
		cout << "Press enter a number:";
		cin >> input;
	if (HelperBot::IsNumeric(input))
	{
		keep_looping = false;
		value_two = HelperBot::ConvertToDouble(input);
		cout << endl;

	}
	else
	{
		cout << endl << "Sorry not a Number!" << endl;
	}
	}
	keep_looping = true;
	
	while (keep_looping)
	{
		cout << "Press enter a number:";
		cin >> input;
	if (HelperBot::IsNumeric(input))
	{
		keep_looping = false;
		value_three = HelperBot::ConvertToDouble(input);
		cout << endl;

	}
	else
	{
		cout << endl << "Sorry not a Number!" << endl;
	}
	}
	cout << Sum(value_one, value_two, value_three);
	
	_getch();
	return 0;

}
double Sum(double value_one, double value_two, double value_three)
{
	double total = 0;
	total = value_one + value_two + value_three;
	return total;
}
