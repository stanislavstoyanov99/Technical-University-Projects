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

	for (unsigned i = 0; i < m_rowSize; i++)
	{
		m_matrix[i] = new double[m_colSize];

		for (unsigned j = 0; j < m_colSize; j++)
		{
			m_matrix[i][j] = initial;
		}
	}
}

// Constructor for given matrix from file - TODO
Matrix::Matrix(const char* fileName)
{
	ifstream file_A(fileName); // input file stream to open the file A.txt

	// Keep track of the column and row sizes
	int colSize = 0;
	int rowSize = 0;

	// read it as a vector
	string line_A;
	int idx = 0;
	double element_A;
	double* vector_A = nullptr;

	if (file_A.is_open() && file_A.good())
	{
		// cout << "File A.txt is open. \n";
		while (getline(file_A, line_A))
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

	m_matrix = new double* [other.m_rowSize];

	for (unsigned i = 0; i < m_rowSize; i++)
	{
		m_matrix[i] = new double[m_colSize];

		for (unsigned j = 0; j < m_colSize; j++)
		{
			m_matrix[i][j] = other.m_matrix[i][j];
		}
	}
}

// Destructor
Matrix::~Matrix()
{
	for (unsigned i = 0; i < m_rowSize; i++)
	{
		delete m_matrix[i];
	}

	delete[] m_matrix;
}

// Addition of two matrices
Matrix Matrix::operator+(Matrix& other)
{
	Matrix sum(m_colSize, m_rowSize, 0.0); // create new matrix instance

	for (unsigned i = 0; i < m_rowSize; i++)
	{
		for (unsigned j = 0; j < m_colSize; j++)
		{
			sum(i, j) = this->m_matrix[i][j] + other(i, j);
		}
	}

	return sum;
}

// Subtraction of two matrices
Matrix Matrix::operator-(Matrix& other)
{
	Matrix diff(m_colSize, m_rowSize, 0.0);

	for (unsigned i = 0; i < m_rowSize; i++)
	{
		for (unsigned j = 0; j < m_colSize; j++)
		{
			diff(i, j) = this->m_matrix[i][j] - other(i, j);
		}
	}

	return diff;
}

// Multiplication of two matrices
Matrix Matrix::operator*(Matrix& other)
{
	Matrix multiply(m_rowSize, other.getCols(), 0.0);

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

				multiply(i, j) = temp;
				// cout << multiply(i,j) << " ";
			}

			// cout << endl;
		}

		return multiply;
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
	for (unsigned i = 0; i < m_rowSize; i++)
	{
		for (unsigned j = 0; j < m_colSize; j++)
		{
			result(i, j) = this->m_matrix[i][j] + scalar;
		}
	}

	return result;
}

// Scalar Subtraction
Matrix Matrix::operator-(double scalar)
{
	Matrix result(m_rowSize, m_colSize, 0.0);
	for (unsigned i = 0; i < m_rowSize; i++)
	{
		for (unsigned j = 0; j < m_colSize; j++)
		{
			result(i, j) = this->m_matrix[i][j] - scalar;
		}
	}

	return result;
}

// Scalar Multiplication
Matrix Matrix::operator*(double scalar)
{
	Matrix result(m_rowSize, m_colSize, 0.0);
	for (unsigned i = 0; i < m_rowSize; i++)
	{
		for (unsigned j = 0; j < m_colSize; j++)
		{
			result(i, j) = this->m_matrix[i][j] * scalar;
		}
	}

	return result;
}

// Scalar Division
Matrix Matrix::operator/(double scalar)
{
	Matrix result(m_rowSize, m_colSize, 0.0);
	for (unsigned i = 0; i < m_rowSize; i++)
	{
		for (unsigned j = 0; j < m_colSize; j++)
		{
			result(i, j) = this->m_matrix[i][j] / scalar;
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

	for (unsigned i = 0; i < m_colSize; i++)
	{
		for (unsigned j = 0; j < m_rowSize; j++)
		{
			transpose(i, j) = this->m_matrix[j][i];
		}
	}

	return transpose;
}

// Get matrix from console
void Matrix::getMatrixFromConsole() const
{
	for (unsigned i = 0; i < m_rowSize; i++)
	{
		for (unsigned j = 0; j < m_colSize; j++)
		{
			cin >> m_matrix[i][j];
		}
	}
}

// TODO
void Matrix::printPrimaryDiagonal(int n) const
{
	cout << "Primary diagonal: ";

	Matrix matrix(n, n, 0.0);

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (i == j)
			{
				matrix(i, j) = this->m_matrix[i][j];
			}
		}
	}

	cout << endl;
}

// TODO
void Matrix::printSecondaryDiagonal(int n) const
{
	cout << "Secondary diagonal: ";

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if ((i+j) == (n-1))
			{
				cout << m_matrix[i][j] << ", ";
			}
		}
	}

	cout << endl;
}

// Prints matrix
void Matrix::print() const
{
	for (unsigned i = 0; i < m_rowSize; i++)
	{
		for (unsigned j = 0; j < m_colSize; j++)
		{
			cout << "[" << m_matrix[i][j] << "]";
		}

		cout << endl;
	}
}