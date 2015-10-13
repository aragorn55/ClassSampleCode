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
	static void SetConsole();

private:

};


#endif // HELPERBOT_H_INCLUDED
