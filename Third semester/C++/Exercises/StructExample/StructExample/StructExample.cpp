// StructExample.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

class Car
{
private:
	string carName;
	int horsePower;
	int years;

public: Car(string carName, int horsePower, int years)
	{
		this->carName = carName;
		this->horsePower = horsePower;
		this->years = years;
	}

public:
	void PrintCarDetails()
	{
		cout << this->carName << endl
			<< this->horsePower << endl
			<< this->years << endl;
	}
};

struct Rectangle
{
	double sizeC;
	double sizeD;
};

struct Square
{
	double sizeA;
	double sizeB;

	double calculateArea();
	double calculatePerimeter(double sizeA, double sizeB);

	double normalFunction(Rectangle rectangle);
	double pointerFunction(Rectangle *pointer);
	double referenceFunction(Rectangle &reference);
};

int main()
{
	Square square = { 5, 4 }; // A = 5, B = 4;
	Rectangle rectangle = { 2, 4 }; // C = 2, D = 4;

	Rectangle *pointer = &rectangle;
	Rectangle &reference = rectangle;

	double resultPointer = square.pointerFunction(pointer);
	cout << resultPointer << endl;

	double resultReference = square.referenceFunction(reference);
	cout << resultReference << endl;

	// TODO learn how to chain constructors
	Car* car = new Car("BMW", 170, 2011);

	// Print with pointer
	car->PrintCarDetails();

	// Print with reference
	Car &carReference = *car;
	carReference.PrintCarDetails();
}

double Square::calculateArea()
{
	return sizeA * sizeB;
}

double Square::calculatePerimeter(double sizeA, double sizeB)
{
	return 2 * (sizeA + sizeB);
}

double Square::normalFunction(Rectangle rectangle)
{
	return rectangle.sizeC;
}

double Square::pointerFunction(Rectangle* pointer)
{
	return pointer->sizeD;
};

double Square::referenceFunction(Rectangle& reference)
{
	return reference.sizeC;
}