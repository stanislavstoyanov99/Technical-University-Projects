// PointersExample.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

void swap1(int a, int b);
void swap2(int* a, int* b);
void swap3(int& a, int& b);

struct A // by default fields are public, we can make them private
{
	int v;
	int h;
};

int main()
{
	int v1 = 3;
	int v4 = 8;

	int* v2 = &v1; // 3
	int* v5 = &v4; // 8

	int& v3 = v1; // 3
	int& v6 = v4; // 8

	swap1(v1, v4);
	swap1(*v2, *v5);
	swap1(v3, v6);

	swap2(&v1, &v4);
	swap2(v2, v5);
	swap2(&v3, &v6);

	swap3(v1, v4);
	swap3(*v2, *v5);
	swap3(v3, v6);

	A s1 = { 5, 8 };

	std::cout << s1.h << std::endl;
}

void swap1(int a, int b)
{
	int temp;
	temp = a;
	a = b;
	b = temp;
}

void swap2(int* a, int* b)
{
	int temp;
	temp = *a;
	*a = *b;
	*b = temp;
}

void swap3(int& a, int& b)
{
	int temp;
	temp = a;
	a = b;
	b = temp;
}