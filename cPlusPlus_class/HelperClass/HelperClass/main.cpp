#include <iostream>
#include <conio.h>
#include <iomanip>
#include <string>
#include "HelperBot.h"
#include "Collection.h"
using namespace std;


struct Student
{
	string FirstName;
	string LastName;
	int Credits;

};
//void prettyPrint(Collection<int>);
int main()
{
	Student jeff;
	jeff.FirstName ="Jeff";
	jeff.LastName = "Richards";
	jeff.Credits = 27;
	Collection<Student> students;
	students.Add(jeff);
	for (int i = 0; i < students.Length(); i++)
	{
		Student tempStudent = students[i];
		cout << tempStudent.LastName << "," << tempStudent.FirstName << endl;
	}
	Collection<string> names;
	names.Add("Rick");
	names.Add("steve");
	names.Add("john");

	cout << "Length of collection: " << names.Length() <<endl;
	cout << names << endl;
	_getch();
		return 0;
}
