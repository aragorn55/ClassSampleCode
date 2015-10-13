#include <iostream>
#include <iomanip>
#include <conio.h>
#include "Rational.h"
int main()
{
	Rational r1(1,4);
	Rational r2(1,3);
	Rational r3;
	r3 = r1 + r2;
	cout << r3;
	
	Rational r4(2,4);
	cout << r4;
	_getch();
	return 0;
}