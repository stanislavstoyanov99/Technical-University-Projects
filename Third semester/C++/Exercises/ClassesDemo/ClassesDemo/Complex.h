#pragma once
class Complex
{
public:
	double* real = new double;
	double* imaginary = new double;

public:
	Complex();
	Complex(const Complex&);
	Complex(double x, double y);

	~Complex();

	void print();
};

