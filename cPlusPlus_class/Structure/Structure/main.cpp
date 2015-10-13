#include <iostream>
#include <conio.h>
#include <iomanip>
#include <string>
#include "..\..\HelperClass\HelperClass\HelperBot.h"
#include "..\..\HelperClass\HelperClass\Collection.h"
using namespace std;
// struct of employee
struct Employee
{
	int Number;
	string Name;
	double Rate;
	double Hours;
};
Collection<Employee> generateSampleData(Collection<Employee>);
Collection<Employee> collectInputData(Collection<Employee>);
int main()
{
	//instantiat employee collection
	Collection<Employee> employees;
	bool valid_input = false;
	double total_gross_pay = 0.0;
	char sample_data_choice;
	int column_width = 20;
	while(!valid_input)
	{
	cout << "Use Sample Data (y/n)? ";
	cin >> sample_data_choice;
	switch (sample_data_choice)
	{

	case 'y':
		employees = generateSampleData(employees);
		 valid_input = true;
			break;
		case 'Y':
			employees = generateSampleData(employees);
			valid_input = true;
			break;
		case 'n':
			employees = collectInputData(employees);
			valid_input = true;
			break;
		case 'N':
			employees = collectInputData(employees);
			valid_input = true;
			break;
		default:
			cout << endl << sample_data_choice << " is not a valid choice";
			cout << endl;
		}
	}
	// set column headers
	cout << left << setw(column_width) << "NUMBER" << setw(column_width)<< "NAME"  << right << setw(column_width) <<" GROSS PAY" << endl;

	for (int i = 0; i < employees.Length(); i++)
	{
		double gross_pay = employees[i].Rate * employees[i].Hours;
		cout << left << setw(column_width) << employees[i].Number << setw(column_width) << employees[i].Name << right << setw(column_width) << fixed  << setprecision(2) << gross_pay << endl << setprecision(0);
		total_gross_pay +=  gross_pay;
	}
	cout <<"Total gross pay of all employees = $" << fixed  << setprecision(2) << total_gross_pay;
	_getch();
		return 0;
}
// auto generate input data
Collection<Employee> generateSampleData(Collection<Employee> employees)
{
	Employee jobs;
	jobs.Name = "Jobs";
	jobs.Hours = 40;
	jobs.Number = 3462;
	jobs.Rate = 4.62;
	Employee hooper;
	hooper.Name = "Hooper";
	hooper.Hours = 38;
	hooper.Number = 6793;
	hooper.Rate = 5.83;
	Employee gates;
	gates.Name = "Gates";
	gates.Hours = 2;
	gates.Number = 3245;
	gates.Rate = 50.99;
	Employee waterman;
	waterman.Name = "Waterman";
	waterman.Hours = 40;
	waterman.Number = 5544;
	waterman.Rate =50.99;
	Employee keane;
	keane.Name = "Keane";
	keane.Hours = 35;
	keane.Number = 4455;
	keane.Rate = 100.00;
	employees.Add(jobs);
	employees.Add(hooper);
	employees.Add(gates);
	employees.Add(waterman);
	employees.Add(keane);
	
	return employees;

}
Collection<Employee> collectInputData(Collection<Employee> employees)
{
		bool valid_input = false;
	string input;
	int num_employees = 0;
	while(!valid_input)
	{
	cout << "How many employees do you want to create? ";
	cin >> input;

	if (HelperBot::IsNumericInt(input))
	{
		num_employees = HelperBot::ConvertToInt(input);
		valid_input =  true;
	}
	else
	{
		cout << endl;
		cout << "that is not a valid number of employees" << endl;
	}
	}
	for (int i = 0; i < num_employees; i++)
	{
		Employee employee;
		valid_input = false;
		while(!valid_input)
	{
		cout << endl;
		cout << "please enter the employees number";
		cin >> input;
		if (HelperBot::IsNumericInt(input))
	{
		employee.Number = HelperBot::ConvertToInt(input);
		valid_input =  true;
	}
	else
	{
		cout << endl;
		cout << "that is not a valid employee number" << endl;
	}
	}
		valid_input = false;
		while(!valid_input)
	{
		cout << endl;
		cout << "please enter the employees name";
		cin >> input;
		if (!(input == ""))
	{
		employee.Name = input;
		valid_input =  true;
	}
	else
	{
		cout << endl;
		cout << "that is not a valid employee name" << endl;
	}
	}
		valid_input = false;
		while(!valid_input)
	{
		cout << endl;
		cout << "please enter the employees rate";
		cin >> input;
		if (HelperBot::IsNumeric(input))
	{
		employee.Rate = HelperBot::ConvertToDouble(input);
		valid_input =  true;
	}
	else
	{
		cout << endl;
		cout << "that is not a valid employee rate" << endl;
	}
	}
		valid_input = false;
		while(!valid_input)
	{
		cout << endl;
		cout << "please enter the employees hours";
		cin >> input;
		if (HelperBot::IsNumeric(input))
	{
		if(HelperBot::ConvertToDouble(input) >= 0)
		{
		employee.Hours = HelperBot::ConvertToDouble(input);
		valid_input =  true;
		}
		else
		{
			cout << endl;
		cout << "that is not a valid number of hours" << endl;
		}
	}
	else
	{
		cout << endl;
		cout << "that is not a valid number of hours" << endl;
	}
	}
		employees.Add(employee);
	}
	return employees;
}