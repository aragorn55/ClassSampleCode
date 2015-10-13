#include <conio.h>
#include <iomanip>
#include <iostream>
#include <string>
#include "..\..\HelperClass\HelperClass\HelperBot.h"

using namespace std;
double ConvertToCelsius(double temperature);
double ConvertToFahrenheit(double temperature);
int main()
{

	double temperature = 0;
	char temperature_scale;



		bool quit = false;
		//get temperature
	cout << endl << "Please enter the temperature: ";
	cin >> temperature;
	
	// get temperature type 
	cout << endl << "Please enter the temperature scale used" << endl <<"'c' for celsius of 'f' for fahrenheit: ";
	cin >> temperature_scale;
		//check temperature type
	//if temperature type c convert to fahrenheit  
	if ( temperature_scale == 'c' || temperature_scale =='C')
	{
		temperature = ConvertToFahrenheit(temperature);
		cout << endl << setprecision(2) << fixed  <<"the temperature is " << temperature << " degrees Fahrenheit" << endl;
	}
		//if temperature type f convert to celsius 
	else if ( temperature_scale == 'f' || temperature_scale =='F')
	{
		temperature = ConvertToCelsius(temperature);
		cout << endl << setprecision(2) << fixed  <<"the temperature is " << temperature << " degrees Celsius" << endl;
	}
	
	// if neither then return an error
	else
	{
		cout << endl << temperature_scale << " is not a valid temperature scale choice";
	}

	_getch();
	return 1;

}
double ConvertToCelsius(double value)
{
//Celsius = (5.0/9.0)*(fahrenheit – 32.0)
	double fahrenheit = value;
	double celsius = 0.0;
	celsius = fahrenheit - 32.0;
	celsius = celsius * (5.0/9.0);
	return celsius;


}
double ConvertToFahrenheit(double celsius)
{
//Fahrenheit = (9.0/5.0)*celsius + 32.0
		double fahrenheit = 0.0;
		fahrenheit = ((9.0 / 5.0) * celsius) + 32.0;
	
	return fahrenheit;


}