#include <iostream>
#include <conio.h>
#include <iomanip>
#include <string>
#include "..\..\HelperClass\HelperClass\HelperBot.h"
using namespace std;

void forLoopTest();
void whileLoopTest();
void doWhileLoopTest();
int main()
{
	
		bool quit = false;
	//loop until a non negative number is entered
	while (!quit)
	{
		forLoopTest();
		cout << endl;
		whileLoopTest();
		cout << endl;
		doWhileLoopTest();
	string input = "";
	cin >> input;
		//cout << endl << "Please enter a non negative number" << endl ;
	
	
	
	
			if (input == "q" || input =="Q")
		{

			quit = true;
		}
	}
	//cout << setprecision(2) << fixed  <<"you made $" << calculateWage(hours_worked) << " dollars this week" << endl;

	
	_getch();
	
	return 0;
}
void forLoopTest()
{
	for (int icnt = 0; icnt < 4; icnt++)
	{
		for (int i = 0; i <= icnt; i++)
		{
			cout << '*';
		}
		cout << endl;
	
	}
	}

void whileLoopTest()
{
	int i = 0;
	string star ="*";
	while (i < 4)
	{
		cout << star << endl;
		star += "*";
		i++;
	}

}
void doWhileLoopTest()
{
	int i = 0;
	string star ="*";
	do
	{
		cout << star << endl;
		star += "*";
		i++;
	} while (i < 4);
}