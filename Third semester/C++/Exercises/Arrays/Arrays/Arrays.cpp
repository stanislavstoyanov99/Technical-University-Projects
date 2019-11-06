// Arrays.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;


void printArrayElements2(int array[], int size)
{
	for (int i = 0; i < size; i++)
	{
		cout << array[i] << ' ';
	}
}

void printArrayElements3(int array[3], int size)
{
	for (int i = 0; i < size; i++)
	{
		cout << array[i] << ' ';
	}
}

void printArrayElements(int *array)
{
	for (int i = 0; i < (sizeof(array)) - 1; i++)
	{
		cout << array[i] << ' ';
	}
}

int main()
{
	int arrayWithSize[5];
	int arrayWithElements[3] = { 1, 2, 3 };

	int arraySize = (sizeof(arrayWithElements) / sizeof(arrayWithElements[0]));
	printArrayElements(arrayWithElements);
	cout << endl;
	printArrayElements2(arrayWithElements, arraySize);
	cout << endl;
	printArrayElements3(arrayWithElements, arraySize);
	cout << endl;

	int* p = new int[2];
	p[0] = 5;
	p[1] = 6;

	p = &arrayWithElements[2];
	cout << *p << endl;

	*(p + 0) = 80;
	*(p + 1) = 45;

	cout << p[0] << endl;

	return 0;
}
