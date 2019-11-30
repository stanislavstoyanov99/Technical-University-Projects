// Functions.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using namespace std;

// Function declaration
void myFunction();
void mySecondFunction(string fname);
void myThirdFunction(string country = "Norway");
void namesAndAge(string fname, string lastName, int age);
void swapNumbers(int &x, int &y);

int plusFunc(int x, int y);
double plusFunc(double x, double y);

int sumFunction(int x, int y);

void oddOrEven(int x);

long factorial(long a);

// The main method
int main()
{
	myFunction();

	mySecondFunction("Liam");
	mySecondFunction("Jenny");
	mySecondFunction("Anja");

	myThirdFunction();
	myThirdFunction("USA");
	myThirdFunction("India");

	namesAndAge("Liam", "Peshov", 3);
	namesAndAge("Jenny", "Kirilov", 14);
	namesAndAge("Anja", "Kanja", 30);

	int result = sumFunction(3, 5);

	cout << result << "\n";

	int firstNum = 15;
	int secondNum = 20;

	cout << "Before swap: " << "\n";
	cout << firstNum << "\t" << secondNum << "\n";

	swapNumbers(firstNum, secondNum);

	cout << "After swap: " << "\n";
	cout << firstNum << "\t" << secondNum << "\n";

	int myNum1 = plusFunc(8, 5);
	double myNum2 = plusFunc(4.3, 6.26);

	cout << "Int: " << myNum1 << "\n";
	cout << "Double: " << myNum2 << "\n";

	/*int number;
	do
	{
		cout << "Please, enter number to check (0 to exit): ";
		cin >> number;
		oddOrEven(number);
	} 
	while (number != 0);*/

	long number = 4;
	cout << number << "! = " << factorial(number);

	return 0;
}

// Function definition
long factorial(long a)
{
	if (a > 1)
	{
		return (a * factorial(a - 1));
	}
	else
	{
		return 1;
	}
}

void oddOrEven(int x)
{
	bool isFinished;

	if ((x % 2) != 0)
	{
		cout << "It is odd.\n";
	}
	else if ((x % 2) == 0)
	{
		if (x == 0)
		{
			cout << "End of program.";
			return;
		}

		cout << "It is even.\n";
	}
}

int plusFunc(int x, int y)
{
	return x + y;
}

double plusFunc(double x, double y)
{
	return x + y;
}

void swapNumbers(int &x, int &y)
{
	int temp = x;
	x = y;
	y = temp;
}

int sumFunction(int x, int y)
{
	return x + y;
}

void namesAndAge(string fname, string lastName, int age)
{
	cout << fname << " " + lastName + " " << age << " years old. \n";
}

void myFunction()
{
	cout << "I just got executed!\n";
}

void mySecondFunction(string fname)
{
	cout << fname << " Refsnes\n";
}

void myThirdFunction(string country)
{
	cout << country << "\n";
}

