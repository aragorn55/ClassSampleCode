#include <iomanip>
#include <iostream>
#include <conio.h>
#include <string>
using namespace std;

int main()
{
	int test[] = {1,2,3,4,5};
	int test_length = 5;
	double d = 45.67890;
	//cout << *(test + 4);
	//cout << test[test_length +1] << " ";
		cout <<sizeof(float);
		cout << "the new line character is \\n.\n";
		cout <<setprecision(2) << d << endl;
		cout << fixed << setprecision(16) << d << endl;
		cout<< setprecision(3)  << fixed << 1.2345;
	_getch();
	return 0;



}