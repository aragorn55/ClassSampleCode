#include <iostream>
#include <conio.h>
#include <iomanip>
#include <string>

using namespace std;
int smallest(int numbers[], int numbers_length);
int length(int numbers[]);
int main()
{
	int sum = 0;

	const int numbers_length = 5;
	int numbers[numbers_length] = {1, 2, 3, 4, 5};
	int numbers_new_length = 5;
	cin >> numbers_new_length;
	int *numbers_new = new int[numbers_new_length];
	int numbers2[] = {1, 2, 3, 4, 5, 6, 7};
	for (int i = 0; i < numbers_length; i++)
	{
		cout <<"Element "<< i << " value is :"<< numbers[i] << endl;
		sum = sum + numbers[i];
		

	}
	//out put sum 
	
	
	cout <<"Sum of numbers in array :"<< sum << endl;
	cout <<"Smallest number in array :"<<  smallest(numbers, numbers_length) << endl;
	length(numbers);
	
	




	_getch();
	return 0;
}
int length(int numbers[])
{
		cout <<"Size of array :" << sizeof(numbers) << endl;
	cout <<"Size of element 0 :" << sizeof(numbers[0]) << endl;
	int length = sizeof(numbers) /  sizeof(numbers[0]);
	cout << "Length of the Arrays: " << length << endl;
	return length;

}


int smallest(int numbers[], int numbers_length)
{

	
		int smallest_value = numbers[0];
	
	for (int i = 0; i < numbers_length; i++)
	{
		
		if (smallest_value > numbers[i])
		{
			smallest_value = numbers[i];
		}

	}
	return smallest_value;
}