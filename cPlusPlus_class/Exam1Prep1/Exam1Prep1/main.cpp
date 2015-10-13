#include <conio.h>
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	double number_cats = 0;
	double cost_per_cat  = 0;
	double price = 0;
	cout << "How many cats would you like? ";
	cin >> number_cats;
	cout << "\nCost per Cat? ";
	cin >> setw(2)>> cost_per_cat;
	price = (float)number_cats * cost_per_cat;
	cout << "\nYou Owe: $" << fixed << setprecision(2) << price;
	_getch();
	return 0;


}