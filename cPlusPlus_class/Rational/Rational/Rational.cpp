#include "Rational.h"


Rational::Rational()
{
    
}
Rational::~Rational()
{
    
}
Rational::Rational(int num, int denom)
{
    _numerator = num;
	_denominator = denom;
	bool testDenom = true;
	while(testDenom)
	{
		testDenom = lower_common_denominator();
	}
}
int Rational::numerator()
{
	return _numerator;
}
int Rational::denominator()
{
	return _denominator;
}
void Rational::set_numerator(int value)
{
	 _numerator = value;
}
void Rational::set_denominator(int value)
{
	 _denominator = value;
}
Rational Rational::operator+(Rational& rational2)
{
	Rational number;
	int num1 = rational2.denominator();
	int num2 = rational2.numerator();
	num2 = num2 * _denominator + num1 * _numerator;
	num1 = num1 * _denominator;
	number.set_numerator(num2);
	number.set_denominator(num1);
	bool testDenom = true;
	while(testDenom)
	{
		testDenom = number.lower_common_denominator();
	}
	return number;
	
}
ostream& operator<<(ostream& out, Rational& s)
{
   // out << s._name << endl;
	out << s._numerator << '/' << s._denominator << endl;
    return out;
}
//getters
 
 //setters
bool Rational::lower_common_denominator()
{
	Collection<int> numerators;
	Collection<int> denominators;
	bool foundaLCV = false;
	if (_numerator > 1)
	{
	//bool testDone =false;
	//while(!testDone)
	//{
		int i = 2;
		while ( i <= _numerator)
		{
			if (_numerator % i == 0)
			{
				numerators.Add(i);
			}
			i++;
		}
		i = 2;
		while ( i < _denominator)
		{
			if (_denominator % i == 0)
			{
				denominators.Add(i);
			}
			i++;
		}
		bool testDone =false;
		i = 0;
	while(!testDone)
	{ 
		int num = numerators[(numerators.Length() - (i + 1))];
		if (denominators.Contains(num))
		{
			testDone = true;
			foundaLCV = true;
			_numerator = _numerator / num;
			_denominator = _denominator / num;
		}
		i++;
	}
	}
	return foundaLCV;
	}

