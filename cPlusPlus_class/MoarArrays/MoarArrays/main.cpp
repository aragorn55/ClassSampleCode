#define _CRT_SECURE_NO_WARNINGS
#include <conio.h>
#include <iostream>
#include <string>
#include "../../HelperClass/HelperClass/HelperBot.h"
string printArray(int[], int);
int main()
{
	//int arr[] = {6, 7, 8, 9, 10};
	//int numbers2[] = {6, 7, 8, 9, 10};
	int length = 5;
	int numbersLength = 5;
	//int* pointer = arr;
	int* numbers = new int[length];
	numbers[0] = 6;
	numbers[1] = 7;
	numbers[2] = 8;
	numbers[3] = 9;
	numbers[4] = 10;

	// arr[0] == pointer
	//cout <<
	//cout << printArray(arr, length);
	//cout << printArray(pointer, size);
	//pointer = numbers2;
	//cout << printArray(pointer, 6);
	_getch();
	return 0;
}
string printArray(int arr[], int length)
{
string output = "";
	output += "{";
	char temp[10] = "";
	for (int i = 0; i < length; i++)
	{
		int value = arr[i];
		sprintf(temp, "%i", value);
		if (i == 0)
		{
			output += temp;
		}
		else
		{
			output += ", ";
			output += temp;

		}
		
	}
	output += "}";
	return output;


}