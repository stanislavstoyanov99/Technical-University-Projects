#include <stdio.h>
#include <stdlib.h>

void geeks()
{
	int var = 20;

	// declare pointer variable
	int *ptr;

	// note that data type of pointer and var must be same
	ptr = &var;

	// assign the address of a variable to a pointer
	printf("Value at ptr = %p \n", ptr); // prints pointer address
	printf("Value at var = %d \n", var); // prints variable
	printf("Value at *ptr = %d \n", *ptr); // prints pointer value
}

//Pass-by-Value
int square1(int n)
{
	//Address of n in square1() is not the same as n1 in main()
	printf("address of n1 in square1(): %d \n", &n);

	// clone modified inside the funcion
	n *= n;
	return n;
}

//Pass-by-Reference with Pointer Arguments
int square2(int *n)
{
	//Address of n in square2() is the same as n2 in main() 
	printf("address of n2 in square2(): ")
}

void writeArrayToFile(int *array, int length)
{
	// creating file pointer to work with files
	FILE *file;

	// opening file in writing mode
	file = fopen("array.txt", "w+");

	for (int i = 0; i < length; i++)
	{
		fprintf(file, "%d ", *array);
		array++;
	}

	fclose(file);
}

void printAndWriteArrayToFile()
{
	// Declare an array
	int array[3] = { 10, 100, 200 };

	// Declare pointer variable
	int *pointer;

	// Assign the address of v[0] to pointer
	pointer = array;

	int length = sizeof(array) / sizeof(array[0]); // array size

	for (int i = 0; i < length; i++)
	{
		printf("Value at ptr = %p \n", pointer);
		printf("Value at *ptr = %d \n", *pointer);

		// Increment pointer by 1
		pointer++;
	}

	pointer = array; // resets pointer values

	writeArrayToFile(pointer, length);
}

// Driver program
int main()
{
	printAndWriteArrayToFile();
	system("pause");
	return 0;
}