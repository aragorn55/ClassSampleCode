#include <iostream>
#include <conio.h>
#include <iomanip>
#include <string>
#include "..\..\HelperClass\HelperClass\HelperBot.h"
using namespace std;

bool TryParse(string, int&);

int main()
{
	
		bool quit = false;

	while (!quit)
	{

		cout << "Please enter a number: ";
		string user_input = "";
		int number = 0;
		cin >> user_input;
		if (TryParse(user_input, number))
		{
			cout << endl << "You entered: " << number << endl;
		
		}
		else
		{

		}
		//<< HelperBot::IsNumeric("Blah");
	char c =_getch();
	if (c == 'q' || c =='Q')
		{

			quit = true;
		}
	}

	
	char c =_getch();
	
	return 0;
}
bool TryParse(string input, int&value)
{
	bool success = HelperBot::IsNumeric(input);
	if (success)
	{
		success = HelperBot::IsNumericInt(input);
		if (success)
		{
			value = HelperBot::ConvertToInt(input);
		}
		else
		{
			double d = HelperBot::ConvertToDouble(input);
			value = (int)d;
		}
		
	}
	return success;
}