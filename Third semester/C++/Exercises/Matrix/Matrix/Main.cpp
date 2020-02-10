#include <fstream> // for file access
#include <iostream>

#include "Matrix.h"

using namespace std;

void readMatrixFromFile(Matrix& matrix, int m_rowSize, int m_colSize);

int main()
{
	int m_rowSize, m_colSize;
	cout << "Enter rows and columns of the matrix:\n";
	cin >> m_rowSize >> m_colSize;

	Matrix firstMatrix(m_rowSize, m_colSize, 0.0);
	cout << "\nEnter the matrix elements one by one:\n";
	firstMatrix.getMatrixFromConsole();

	cout << "\nEntered matrix is:\n";
	firstMatrix.print();

	Matrix secondMatrix = firstMatrix; // invoke copy constructor
	cout << "\nResult of the copy constructor is:\n";
	secondMatrix.print();

	Matrix duplicatedMatrix;
	duplicatedMatrix = firstMatrix; // invoke operator=
	cout << "\nResult of assignment operator:\n";
	duplicatedMatrix.print();

	Matrix transposedMatrix = duplicatedMatrix.transpose();
	cout << "\nResult of transposed matrix:\n";
	transposedMatrix.print();

	cout << "\nResult of new matrix with initial values:\n";
	Matrix testMatrix(m_rowSize, m_colSize, 7);
	testMatrix.print();

	cout << "\nPrint primary and secondary diagonals:\n";
	transposedMatrix.printPrimaryDiagonal(m_rowSize);
	transposedMatrix.printSecondaryDiagonal(m_rowSize);

	cout << "\nRead matrix from file:\n";
	Matrix matrix(m_rowSize, m_colSize, 0.0);
	readMatrixFromFile(matrix, m_rowSize, m_colSize);
	matrix.print();
}

// TODO
void readMatrixFromFile(Matrix& matrix, int m_rowSize, int m_colSize)
{
	ifstream file("matrix.txt");

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_colSize; col++)
		{
			file >> matrix(row, col);
		}
	}

	file.close();
}
