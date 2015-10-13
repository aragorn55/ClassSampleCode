#include <iostream>
#include <conio.h>
#include <iomanip>
#include "..\..\HelperClass\HelperClass\HelperBot.h"

using namespace std;
// did not use notes
int main ()
{
	bool valid_number = false;
	string input = "";
	int numbers_length = 0;
	int numbers_Sum = 0;
	int *numbers = new int[numbers_length];
	//while not a valid number loop
	while(!valid_number)
	{
		cout << "please enter how many numbers to add: ";
		cin >> input;
		cout << endl;
		//if input is an integer set it to the arrays length
		if(HelperBot::IsNumericInt(input))
		{
			valid_number = true;
			numbers_length = HelperBot::ConvertToInt(input);
		}

	}
	//set array to length entered b y user
	numbers = new int[numbers_length];
	//loop once for each number the user said they would enter
	for (int i = 0; i < numbers_length; i++)
	{
		//reset number_valid to false for each new num ber enterd
		 valid_number = false;
		 //while not a valid number loop
		while(!valid_number)
	{
		cout << "please enter a non decimal number: ";
		cin >> input;
		cout << endl;
		//if input is an integer add it to the array and tell the loop the number is valid
		if(HelperBot::IsNumericInt(input))
		{
			valid_number = true;
			int number = 0;
			number = HelperBot::ConvertToInt(input);
			numbers[i] = number;
		}
	}
	}
	// sum up all the numbers in the array
	for (int e = 0; e < numbers_length; e++)
	{
		numbers_Sum += numbers[e];

	}
	//out put the numbers entered in reverse order
	cout << "The total sum of the numbers {";
	for (int j = (numbers_length - 1); j >= 0; j--)
	{
		if (j == (numbers_length - 1))
		{
		cout<< numbers[j];
		}
		else
		{
			cout << ", " << numbers[j];

		}
		}
	cout <<  "} is: " << numbers_Sum << endl;


	_getch();
	return 0;
}