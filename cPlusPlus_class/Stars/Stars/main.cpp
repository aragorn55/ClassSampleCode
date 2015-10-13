#include <iostream>
#include <conio.h>
#include <iomanip>
#include <string>
#include "..\..\HelperClass\HelperClass\HelperBot.h"
using namespace std;

void starBuilder();

int main()
{
	starBuilder();
	_getch();
	
	return 0;
}
void starBuilder()
{
	// loop once for line
	for (int icnt = 0; icnt < 11; icnt++)
	{
		//for first star triangle start with one * increase by one eachline 
		for (int i = 0; i <= icnt; i++)
		{
			cout << '*';
		}
		// create fill spaces for remander of triangle start with 10 go to 0
		for (int j = 0; j < (10 - icnt); j++)
		{
			cout << ' ';
		}
		//space between triangles
		cout << ' ';
		// now start with eleven stars and go down by one
		for (int g = 0; g <= (10 - icnt); g++)
		{
			cout << '*';
		}
		// create fill spaces for remander of triangle start with 0 go to 10
		for (int z = 0; z < icnt; z++)
		{
			cout << ' ';
		}
		cout << ' ';
		// create fill spaces for remander of triangle basicly first with  spaces start with 0 go to 10
		for (int z = 0; z < icnt; z++)
		{
			cout << ' ';
		}
		// now start with eleven stars and go down by one
		for (int g = 0; g <= (10 - icnt); g++)
		{
			cout << '*';
		}
		cout << ' ';
		// create fill spaces for remander of triangle basicly first fill spaces start with 10 go to 0
		for (int j = 0; j < (10 - icnt); j++)
		{
			cout << ' ';
		}
		//for first star triangle start with one * increase by one eachline 
		for (int i = 0; i <= icnt; i++)
		{
			cout << '*';
		}
		cout << endl;
	
	}
	}
