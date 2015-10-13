#ifndef HELPERBOT_H_INCLUDED
#define HELPERBOT_H_INCLUDED
#include <string>
using namespace std;
class Helperbot
{
private:

public:
	static bool IsNumeric(string);
	static bool IsNumericInt(string);
	static int ConvertToInt(string);
	static double ConvertToDouble(string);
	static bool TryParse(string, int&);
	static string ToCurrency(double);
    static string PrintArray(int[], int);

private:

};


#endif // HELPERBOT_H_INCLUDED
