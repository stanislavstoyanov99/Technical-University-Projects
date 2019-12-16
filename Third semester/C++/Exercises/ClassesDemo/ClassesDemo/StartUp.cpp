#include <iostream>

#include "Complex.h"

int main()
{
	Complex* complex = new Complex();
	complex->print();

	Complex* secondComplex = complex;
	secondComplex->print();
}
