#include <iostream>
#include <string>

#include "Complex.h"

Complex::Complex()
{
	*real = 0;
	*imaginary = 0;
}

Complex::Complex(const Complex& constant)
{
	*real = *constant.real;
	*imaginary = *constant.imaginary;
}

Complex::Complex(double x, double y)
{
	*real = x;
	*imaginary = y;
}

Complex::~Complex()
{
	delete real;
	delete imaginary;
}

void Complex:: print()
{
	std::cout << std::to_string(*real) + " " + std::to_string(*imaginary) << std::endl;
}
