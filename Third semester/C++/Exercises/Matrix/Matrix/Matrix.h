#include <fstream> // for file access
#include <iostream>

using namespace std;

#pragma once
class Matrix
{
private:
	unsigned m_rowSize; // cannot be negative, saves memory space
	unsigned m_colSize; // cannot be negative, saves memory space
	double** m_matrix;
public:
	Matrix();
	Matrix(unsigned, unsigned, double); // holds row size, column size, initial value for each cell
	Matrix(const Matrix&); // copy constructor
	~Matrix(); // destructor

	// Matrix Operations
	Matrix operator+(Matrix&); // sum two matrices
	Matrix operator-(Matrix&); // subtract two matrices
	Matrix operator*(Matrix&); // multiply two matrices
	Matrix operator=(Matrix&);
	Matrix transpose();

	// Scalar Operations
	Matrix operator+(double);
	Matrix operator-(double);
	Matrix operator*(double);
	Matrix operator/(double);

	// Another Methods
	double& operator()(const unsigned&, const unsigned&); // Matrix(3,4)
	void print() const;
	unsigned getRows() const;
	unsigned getCols() const;
	void getMatrixFromConsole() const;
	void printPrimaryDiagonal(unsigned) const;
	void printSecondaryDiagonal(unsigned) const;
	void writeMatrixToFile() const;
};

