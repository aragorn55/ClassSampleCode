#include <iostream>
#include <conio.h>
#include <iomanip>
#include <string>
#include "..\..\HelperClass\HelperClass\HelperBot.h"
#include "Math.h"

using namespace std;

int main()
{
	//create variables
	HelperBot h = HelperBot();
	Math m = Math();
	bool keep_looping = true;
	string option;
	string input_one;
	string input_two;
	double num_one = 0;
	double num_two = 0;
	double num_answer = 0;
	//loop untill user says to stop
	while (keep_looping)
	{
	bool valid_option = false;
	bool valid_number = false;
	//loop until a number is entered 
	while (!valid_number)
	 {
		cout << "Please enter a number: ";
		cin >> input_one;
		if (h.IsNumeric(input_one))
		{
			num_one = h.ConvertToDouble(input_one);
			valid_number = true;
		}
		else
		{
			cout << endl << input_one <<" is not a number." << endl;
		}
		}
	valid_number = false;
	//loop until a number is entered 
	while (!valid_number)
		{
			cout << "Please enter a second number: ";
		cin >> input_two;
		if (h.IsNumeric(input_two))
		{
			num_two = h.ConvertToDouble(input_two);
			valid_number = true;
		}
		else
		{
			cout << endl << input_two <<" is not a number." << endl;
		}
		}
	// loop until user quits or enters a menu choice
	while (!valid_option)
	{
		 cout << "Select menu option, 'q' to quit:" << endl;
		cout << "1. Add the first number to the second number" << endl;
		cout << "2. Subtract the second  number from the first number" << endl;
		cout << "3. Multiply the two numbers" << endl;
		cout << "4. Divide the first number by the second number" << endl;
		cout << "5. find the average of the two numbers" << endl;
		cin >> option;
		// check if user chose to quit
		if (option == "q" || option == "Q")
			{
				keep_looping = false;
				valid_option = true;
			}
		else
		 {
			if (h.IsNumericInt(option))
			 {							
				//do whatever
				int num_option = h.ConvertToInt(option);
				switch (num_option)
				 {
					case 1:
						// add
						num_answer = m.Add(num_one, num_two);
						cout << "the answer is  " << num_answer << endl;
						valid_option = true;
						break;
					case 2:
						// subtract
						num_answer = m.Subtract(num_one, num_two);
						cout << "the answer is  " << num_answer << endl;
						valid_option = true;
						break;
					case 3:
						// Mult
						num_answer = m.Multiply(num_one, num_two);
						cout << "the answer is  " << num_answer << endl;
						valid_option = true;
						break;
					case 4:
						// Divide
						num_answer = m.Divide(num_one, num_two);
						cout << "the answer is  " << num_answer << endl;
						valid_option = true;
						break;
					case 5:
						// Average
						num_answer = m.FindAverage(num_one, num_two);
						cout << "the answer is  " << num_answer << endl;
						valid_option = true;
						break;
					default:
						//error
						cout << option <<  " is not a valid option. Please enter a valid option!" << endl;
					}
					
				}
				else
				{
					cout << option <<  " is not a valid option. Please enter a valid option!" << endl;
			}
	}
	}
	}
	_getch();


	return 0;

}