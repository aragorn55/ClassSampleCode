#include <iostream>
#include <conio.h>
#include <iomanip>
#include <string>
#include "Helper.h"

using namespace std;

int main()
{
	
	Helper::SetConsole();
	
	bool quit = false;
	do	
	{
		cout << "press q to quit";
	//	string input = "";
	//	cin >> input;
		///if (input == "q" || input =="Q")
	//	{

	//		quit = true;
	//	}
	}while (_getch() != 'q');
	_getch();
	return 0;
}

