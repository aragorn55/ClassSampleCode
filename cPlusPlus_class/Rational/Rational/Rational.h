#ifndef RATIONAL_H
#define RATIONAL_H
#include <string>
#include <iostream>
#include "Collection.h"
using namespace std;
class Rational
{
	public:
	//getters
	Rational operator+(Rational& rational2);
	int numerator();
	int denominator();
	void set_numerator(int);
	void set_denominator(int);
	bool lower_common_denominator();
	//setters
	

	friend ostream& operator<<(ostream&, Rational&);
	Rational();
	 Rational(int, int);
	~Rational();
	protected:
	private:
	//private variables
	
	int _numerator;
	int _denominator;
};

#endif // RATIONAL_H
