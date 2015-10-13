#include <iostream>
#include <conio.h>
#include <iomanip>
#include <string>
#include "..\..\HelperClass\HelperClass\HelperBot.h"
using namespace std;

void forLoopTest();

int main()
{
	
		bool quit = false;
	//loop until a non negative number is entered
	while (!quit)
	{

	string input = "";
	cin >> input;
		//cout << endl << "Please enter a non negative number" << endl ;
	
	
	
	
			if (input == "q" || input =="Q")
		{

			quit = true;
		}
	}


	
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

