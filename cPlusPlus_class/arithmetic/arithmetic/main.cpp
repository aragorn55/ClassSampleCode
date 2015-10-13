#include <iostream>
#include <conio.h>
#include <iomanip>
#include <string>
#include "Helper.h"


using namespace std;

int main()
{
	Helper h = Helper();
	
	cout << h.IsNumeric("abc") << endl;
	bool keep_looping = true;
	while (keep_looping)
	{
		cout << "Select menu option, 'q' to quit:" << endl;
		cout << "1. Addition" << endl;
		cout << "2. Multiplication" << endl;
			string option;
			cin >> option;
			if (option == "q" || option == "Q")
			{
				keep_looping = false;
			}
			else
			{
				if (h.IsNumericInt(option))
				{
					int num_one;
					int num_two;
					int num_answer;

					cout << "First number?";
					cin >> num_one;
					cout << "First number?";
					cin >> num_two;

					//do whatever
					int num_option = h.ConvertToInt(option);
					switch (num_option)
					{
					case 1:
						// add
						num_answer = num_one + num_two;
						cout << "the answer is  " << num_answer << endl;
						break;
					case 2:
						// Mult
						num_answer = num_one * num_two;
						cout << "the answer is  " << num_answer << endl;
						break;
					default:
						//error
						cout << "Please enter a valid number!" << endl;


					}
					
				}
				else
				{
					cout << "Please enter a valid number!" << endl;
			}
	}
	
	
	_getch();


	return 0;

}