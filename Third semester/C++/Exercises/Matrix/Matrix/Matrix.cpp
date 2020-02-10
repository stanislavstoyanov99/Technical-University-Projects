#include "Matrix.h"

using namespace std;

// Default constructor
Matrix::Matrix()
{
	m_rowSize = 0;
	m_colSize = 0;
	m_matrix = NULL;
}

// Constructor for any matrix
Matrix::Matrix(unsigned rowSize, unsigned colSize, double initial = 0.0)
{
	m_rowSize = rowSize;
	m_colSize = colSize;
	m_matrix = new double* [m_rowSize];

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		m_matrix[row] = new double[m_colSize];

		for (unsigned col = 0; col < m_colSize; col++)
		{
			m_matrix[row][col] = initial;
		}
	}
}

// Constructor for given matrix from file - TODO
Matrix::Matrix(const char* fileName)
{
	ifstream matrixFile(fileName); // input file stream to open the file matrix.txt

	// Keep track of the column and row sizes
	int colSize = 0;
	int rowSize = 0;

	// read it as a vector
	string line_A;
	int idx = 0;
	double element_A;
	double* vector_A = nullptr;

	if (matrixFile.is_open() && matrixFile.good())
	{
		cout << "File matrix.txt is open. \n";

		while (getline(matrixFile, line_A))
		{
			rowSize += 1;
			stringstream stream_A(line_A);
			colSize = 0;

			while (1)
			{
				stream_A >> element_A;
				if (!stream_A)
				{
					break;
				}
				colSize += 1;
				double* tempArr = new double[idx + 1];
				copy(vector_A, vector_A + idx, tempArr);
				tempArr[idx] = element_A;
				vector_A = tempArr;
				idx += 1;
			}
		}
	}
	else
	{
		cout << "Failed to open. \n";
	}

	int j;
	idx = 0;

	m_matrix = new double* [m_rowSize];

	for (unsigned i = 0; i < m_rowSize; i++)
	{
		m_matrix[i] = new double[m_colSize];
	}

	for (int i = 0; i < rowSize; i++)
	{
		for (int j = 0; j < colSize; j++)
		{
			this->m_matrix[i][j] = vector_A[idx];
			idx++;
		}
	}

	m_colSize = colSize;
	m_rowSize = rowSize;
	delete[] vector_A;
}

// Copy constructor
Matrix::Matrix(const Matrix& other)
{
	cout << "\nCopy constructor invoked\n";
	m_rowSize = other.m_rowSize;
	m_colSize = other.m_colSize;

	m_matrix = new double* [other.m_rowSize]; // create new instance

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		m_matrix[row] = new double[m_colSize];

		for (unsigned col = 0; col < m_colSize; col++)
		{
			m_matrix[row][col] = other.m_matrix[row][col];
		}
	}
}

// Destructor
Matrix::~Matrix()
{
	for (unsigned row = 0; row < m_rowSize; row++)
	{
		delete m_matrix[row];
	}

	delete[] m_matrix;
}

// Addition of two matrices
Matrix Matrix::operator+(Matrix& other)
{
	Matrix resultMatrix(m_colSize, m_rowSize, 0.0); // create new matrix instance

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_colSize; col++)
		{
			resultMatrix(row, col) = this->m_matrix[row][col] + other(row, col);
		}
	}

	return resultMatrix;
}

// Subtraction of two matrices
Matrix Matrix::operator-(Matrix& other)
{
	Matrix resultMatrix(m_colSize, m_rowSize, 0.0);

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_colSize; col++)
		{
			resultMatrix(row, col) = this->m_matrix[row][col] - other(row, col);
		}
	}

	return resultMatrix;
}

// Multiplication of two matrices : TODO
Matrix Matrix::operator*(Matrix& other)
{
	Matrix resultMatrix(m_rowSize, other.getCols(), 0.0);

	if (m_colSize == other.getRows())
	{
		double temp = 0.0;

		for (unsigned i = 0; i < m_rowSize; i++)
		{
			for (unsigned j = 0; j < other.getCols(); j++)
			{
				temp = 0.0;

				for (unsigned k = 0; k < m_colSize; k++)
				{
					temp += m_matrix[i][k] * other(k, j);
				}

				resultMatrix(i, j) = temp;
				// cout << multiply(row,col) << " ";
			}

			// cout << endl;
		}

		return resultMatrix;
	}
	else
	{
		return "Column size of the first matrix should be equal to the row number of the second matrix.";
	}
}

Matrix Matrix::operator=(Matrix& other)
{
	swap(m_matrix, other.m_matrix);
	swap(m_rowSize, other.m_rowSize);
	swap(m_colSize, other.m_colSize);

	return *this;
}

// Scalar Addition
Matrix Matrix::operator+(double scalar)
{
	Matrix result(m_rowSize, m_colSize, 0.0);

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_colSize; col++)
		{
			result(row, col) = this->m_matrix[row][col] + scalar;
		}
	}

	return result;
}

// Scalar Subtraction
Matrix Matrix::operator-(double scalar)
{
	Matrix result(m_rowSize, m_colSize, 0.0);

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_colSize; col++)
		{
			result(row, col) = this->m_matrix[row][col] - scalar;
		}
	}

	return result;
}

// Scalar Multiplication
Matrix Matrix::operator*(double scalar)
{
	Matrix result(m_rowSize, m_colSize, 0.0);

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_colSize; col++)
		{
			result(row, col) = this->m_matrix[row][col] * scalar;
		}
	}

	return result;
}

// Scalar Division
Matrix Matrix::operator/(double scalar)
{
	Matrix result(m_rowSize, m_colSize, 0.0);

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_colSize; col++)
		{
			result(row, col) = this->m_matrix[row][col] / scalar;
		}
	}

	return result;
}

// Returns value of given location when asked in the form Matrix(x,y)
double& Matrix::operator()(const unsigned& rowNumber, const unsigned& colNumber)
{
	return this->m_matrix[rowNumber][colNumber];
}

// Row size getter
unsigned Matrix::getRows() const
{
	return this->m_rowSize;
}

// Col size getter
unsigned Matrix::getCols() const
{
	return this->m_colSize;
}

// Take any given matrices transpose and returns another matrix
Matrix Matrix::transpose()
{
	Matrix transpose(m_colSize, m_rowSize, 0.0);

	for (unsigned row = 0; row < m_colSize; row++)
	{
		for (unsigned col = 0; col < m_rowSize; col++)
		{
			transpose(row, col) = this->m_matrix[col][row];
		}
	}

	return transpose;
}

// Get matrix from console
void Matrix::getMatrixFromConsole() const
{
	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_colSize; col++)
		{
			cin >> m_matrix[row][col];
		}
	}
}

void Matrix::printPrimaryDiagonal(unsigned m_rowSize) const
{
	cout << "Primary diagonal: ";

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_rowSize; col++)
		{
			if (row == col)
			{
				cout << m_matrix[row][col] << ", ";
			}
		}
	}

	cout << endl;
}

void Matrix::printSecondaryDiagonal(unsigned m_rowSize) const
{
	cout << "Secondary diagonal: ";

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_rowSize; col++)
		{
			if ((row+col) == (m_rowSize - 1))
			{
				cout << m_matrix[row][col] << ", ";
			}
		}
	}

	cout << endl;
}

void Matrix::writeMatrixToFile() const
{
	ofstream file("matrix.txt");

	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_colSize; col++)
		{
			file << "[" << m_matrix[row][col] << "]";
		}

		file << "\n";
	}

	file.close();
}

// Prints matrix
void Matrix::print() const
{
	for (unsigned row = 0; row < m_rowSize; row++)
	{
		for (unsigned col = 0; col < m_colSize; col++)
		{
			cout << "[" << m_matrix[row][col] << "]";
		}

		cout << endl;
	}
}