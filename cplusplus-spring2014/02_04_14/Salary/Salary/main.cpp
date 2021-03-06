#include <iostream>
#include <conio.h>
#include <iomanip>
//need for shell color on windows machine
#include <Windows.h>
#include <string>



using namespace std;

//need to declare (but not define) before use
void setConsole();

double calculateWage(double, double);


int main()
{
	setConsole();
  	//declare variables
	double salary = 0;
	double hours_per_week = 0;
	

	string name = "";
	cout << "Please enter your salary:";
	cin >> salary;
	cout << "Please enter hours per week:";
	cin >> hours_per_week;
	
	

	cout << endl << "Your hourly wage is:" << calculateWage(salary, hours_per_week);
	
	/*
	cout << endl << "Please enter you name:";
	cin >> name;
	cout << "Your Name is " << name;
	*/
	_getch();
	return 0;
}

void setConsole()
{
	 //color value for console
	int color = 25;  
	//console reference	
	HANDLE	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	//this will loop until either 0 is entered, or a non-numeric value

   	PCONSOLE_FONT_INFOEX font = new CONSOLE_FONT_INFOEX();
   	font->cbSize = sizeof(CONSOLE_FONT_INFOEX);
   
    	//CONSOLE_FONT_INFOEX is defined in some windows header
    	GetCurrentConsoleFontEx(hConsole, false, font);
	//PCONSOLE_FONT_INFOEX is the same as CONSOLE_FONT_INFOEX*
    	font->dwFontSize.X = 10;
    	font->dwFontSize.Y = 18;
	SetCurrentConsoleFontEx(hConsole, false, font);
	SetConsoleTextAttribute(hConsole, 240); 
}
