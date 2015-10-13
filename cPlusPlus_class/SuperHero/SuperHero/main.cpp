#include <iostream>
#include <iomanip>
#include <conio.h>
#include "SuperHero.h"
#include <string>
using namespace std;

int main()
{
	
	SuperHero heroes[3];
	heroes[0] = SuperHero("Bruce", "Banner", "Hulk Smash", "Hulk");
	heroes[1] = SuperHero("Eric", "Masterson", "Mjolnir", "Thor");
	heroes[2] = SuperHero("Henry", "Pymn", "Grow/Shrink", "Ant Man");
	cout << "hello world" << endl;
	for ( int icnt = 0; icnt < 3; icnt++)
	{

		cout << heroes[icnt].name() << " "<< heroes[icnt].power() << endl;

	}
	cout << "Please enter a first name to search:";
	string first_name = "";
	//cin >> first_name;
	getline(cin, first_name);
	bool foundHero = false;
	int i = 0;
	while (!foundHero && i < 3)
	{
		if ((first_name == heroes[i].first_name())||(first_name == heroes[i].name())||(first_name == heroes[i].last_name())||(first_name == heroes[i].power()))
		{
		cout <<"found \"" << first_name  << "\" on: " << heroes[i].name() << " = " << heroes[i].first_name()  << " " << heroes[i].last_name() << " "<< heroes[i].power() << endl;
		foundHero = true;
		}
		i++;
		
	}
	_getch();
	return 0;

}