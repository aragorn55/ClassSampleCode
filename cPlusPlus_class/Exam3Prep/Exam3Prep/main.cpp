#include <iomanip>
#include <conio.h>
#include <iostream>
#include <string>
using namespace std;
int main()
{
	int numNames = 0;
	cout << "How many names? ";
	cin >> numNames;
	string* Names = new string[numNames];
	for (int i = 0; i < numNames; i++)
	{
		string name = "";
	cout<< endl << "name" << i + 1 << "? ";

	cin >> name;
		Names[i] = name;
	}
	cout << endl << "Name: ";
	for (int e = numNames -1; e >= 0; e--)
	{
		string sName = Names[e];
		
		cout << Names[e];
		if (e > 0)
		{
			cout << ", ";
		}
	}
	_getch();
		return 0;
	//

}