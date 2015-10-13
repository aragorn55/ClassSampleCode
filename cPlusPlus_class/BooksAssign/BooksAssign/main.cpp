#include <iostream>
#include <conio.h>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	int numBooks = 0;
	double bookPrice = 0.0;
	double totalPrice = 0.0;
	cout << "Enter the number of books: ";
	cin >> numBooks;
	cout << "\n Enter the prive per book: ";
	cin >> bookPrice;
	totalPrice = numBooks * bookPrice;
	cout << "The total price is : ";
cout << fixed << setprecision(2) << totalPrice;
	_getch();
	return 0;
}