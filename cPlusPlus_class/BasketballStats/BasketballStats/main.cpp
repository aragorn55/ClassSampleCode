#include <conio.h>
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	string badgers_name ="Badgers";
	double badgers_wins = 17;
	double badgers_losses = 4;
	string gophers_name = "Golden Gophers"; 
	double gophers_wins = 15;
	double gophers_losses = 6;
	int column_width = 10;
	int column_width_wide = 20;
	cout << fixed << setprecision(0);
	cout << left << setw(column_width) << "Team" << "\t"  << right << "Win" << "\t" << "Loss" << "\t";

	cout << setw(column_width_wide) << "Average Win/loss" << endl;

	cout << left << setw(column_width)<<  badgers_name << "\t"  << right << badgers_wins << "\t" << badgers_losses  << "\t" << setprecision(2)<< setw(column_width_wide) << badgers_wins / badgers_losses << setprecision(0) << endl;

	cout  << left << setw(column_width) << gophers_name << "\t"  << right << gophers_wins << "\t" << gophers_losses  << "\t";

	cout << setprecision(2) << setw(column_width_wide) <<  gophers_wins / gophers_losses << setprecision(0) << endl;



	


	_getch();
	return 0;
}