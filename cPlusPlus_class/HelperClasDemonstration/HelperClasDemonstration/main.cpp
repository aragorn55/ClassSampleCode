#include <iostream>
#include <conio.h>
#include <iomanip>
#include <string>
#include "..\..\HelperClass\HelperClass\HelperBot.h"
using namespace std;

int main()
{
	cout << "Press enter a number:";
	string input = "";
	cin >> input;
	if (HelperBot::IsNumeric(input))
	{
		cout << endl << "Good Job!" << endl;
		cout << "you entered: " << HelperBot::ConvertToInt(input) << endl;
	}
	else
	{
		cout << endl << "Sorry not an integer!" << endl;
	}
	bool quit = false;

	while (!quit)
	{
	cout << "Press any key to include, 'q' to quit." << endl;
	char c = _getch();
	if ( c == 'q' || c =='Q') quit = true;
	}
	return 0;
}