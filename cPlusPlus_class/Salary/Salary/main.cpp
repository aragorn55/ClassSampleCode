#include <conio.h>
#include <iomanip>
#include <iostream>
#include <string>


using namespace std;
double calculateWage(double salary, double hours_per_year);
int main()
{
	double salary = 0;
	double hours_per_week = 0;
	cout << "hello"<< endl;
	cin >> salary;
	cin >> hours_per_week;
	cout << calculateWage(salary, hours_per_week) <<endl;
	_getch();
	return 1;

}
double calculateWage(double salary, double hours_per_week)
{
	double hours_per_year = hours_per_week * 50;
	double wage = salary / hours_per_year;
	return wage;

}