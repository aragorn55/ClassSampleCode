#include <conio.h>
#include <iomanip>
#include <string>
#include <iostream>
#include "..\..\HelperClass\HelperClass\HelperBot.h"
using namespace std;
double find_average(double, double, double);
// did not look at other code
int main()
{
	bool keep_looping = true;
	double num_one = 0;
	double num_two = 0;
	double num_three = 0;
	string input;
	//loop until user sends quit
	while(keep_looping)
	{
		bool is_valid_number = false;
		// loop until user enters a number
		while (!is_valid_number)
		{
			cout << "Enter a number: ";
			cin >> input;
			//check input is a number if it is convert it to a double
			if (HelperBot::IsNumeric(input))
			{
				num_one = HelperBot::ConvertToDouble(input);
				is_valid_number = true;
			}
			else
			{
				cout << endl << input << " is not a number." << endl; 
			}
	
		}
		is_valid_number = false;
		// loop until user enters a number
		while (!is_valid_number)
		{
			cout << "Enter a second number: ";
			cin >> input;
			//check input is a number if it is convert it to a double
			if (HelperBot::IsNumeric(input))
			{
				num_two = HelperBot::ConvertToDouble(input);
				is_valid_number = true;
			}
			else
			{
				cout << endl << input << " is not a number." << endl; 
			}
	
		}
		is_valid_number = false;
		// loop until user enters a number
		while (!is_valid_number)
		{
			cout << "Enter a third number: ";
			cin >> input;
			//check input is a number if it is convert it to a double
			if (HelperBot::IsNumeric(input))
			{
				num_three = HelperBot::ConvertToDouble(input);
				is_valid_number = true;
			}
			else
			{
				cout << endl << input << " is not a number." << endl; 
			}
	
		}
		// output average to one decimal point
		cout << "the average is :" << setprecision(1) << fixed << find_average(num_one, num_two, num_three) << endl;
		//ask user if they want to quit
		cout << "enter 'q' to quit or any other letter to continue :";
		cin >> input;
		if ((input == "q")||(input == "Q"))
		{
			keep_looping = false;
		}

	}


	

	_getch();
	return 0;
}
double find_average(double value_one, double value_two, double value_three)
{
	double average = 0;
	// add three values together and divide by three
	average = (value_one + value_two + value_three) / 3;
	// return result
	return average;
	

}