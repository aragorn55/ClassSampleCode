#include <iostream>
#include <conio.h>
#include <iomanip>
//need for shell color on windows machine
#include <Windows.h>
using namespace std;

//need to declare (but not define) before use
//void setConsole();

int main()
{


	int column_one_width = 112;


	//setConsole();


	// Set alignment to left
	cout << left << setw(column_one_width) << "Computers, computers everywhere" << endl;
	cout << setw(column_one_width) << "  as far as I can C." << endl;
	cout << setw(column_one_width) << "I really, really like these things." << endl;
	cout << setw(column_one_width) << "  Oh joy. Oh joy for me!" << endl;
	
	
	_getch();
	return 0;
}

//void setConsole()
//{

//}