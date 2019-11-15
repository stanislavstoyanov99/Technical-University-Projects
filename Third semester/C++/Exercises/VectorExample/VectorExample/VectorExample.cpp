// VectorExample.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
#include <list>
#include <map>

using namespace std;

int main()
{
	vector<int> v(10);

	map<int, string> map;
	map[0] = "pesho";

	for (int i = 1; i <= 5; i++)
	{
		v.push_back(i);
	}

	cout << "Output of begin and end: ";
	for (auto i = v.begin(); i != v.end(); i++)
	{
		cout << *i << " "; // 1 2 3 4 5
	}

	for (int i = 0; i < v.size(); i++)
	{
		cout << v[i] << " ";
	}

	cout << "\nOutput of cbegin and cend: ";
	for (auto i = v.cbegin(); i != v.cend(); i++)
	{
		cout << *i << " "; // 1 2 3 4 5
	}

	cout << "\nOutput of rbegin and rend: ";
	for (auto ir = v.rbegin(); ir != v.rend(); ir++)
	{
		cout << *ir << " "; // 5 4 3 2 1
	}

	cout << "\nOutput of crbegin and crend: ";
	for (auto ir = v.crbegin(); ir != v.crend(); ir++)
	{
		cout << *ir << " "; // 5 4 3 2 1
	}

	cout << "\nSize: " << v.size();
	cout << "\nCapacity: " << v.capacity();
	cout << "\nMax_Size: " << v.max_size();

	// resizes the vector size to 4
	v.resize(4);

	// prints the vector size after resize()
	cout << "\nSize: " << v.size();

	// checks if the vector is empty or not
	if (v.empty() == false)
	{
		cout << "\nVector is not empty";
	}
	else
	{
		cout << "\nVector is empty";
	}

	// Shrinks the vector
	v.shrink_to_fit();
	cout << "\nVector elements are: ";
	for (auto it = v.begin(); it != v.end(); it++)
	{
		cout << *it << " ";
	}

	cout << "\nReference operator [g] : g1[2] = " << v[2];
	cout << "\nat : vector.at(4) = " << v.at(3);
	cout << "\nfront() : vector.front() = " << v.front();
	cout << "\nback() : vector.back() = " << v.back();

	int* pos = v.data();
	cout << "\nThe first element is " << *pos;

	vector<int> newVector;
	newVector.assign(5, 10);

	cout << "\nThe vector elements are: ";
	for (int i = 0; i < newVector.size(); i++)
	{
		cout << newVector[i] << " ";
	}

	// Inserts 15 to the last position
	newVector.push_back(15);
	int n = newVector.size();
	cout << "\nThe last element is: " << newVector[n - 1];

	// Removes the last element
	newVector.pop_back();

	cout << "\nThe vector elements are: ";
	for (int i = 0; i < newVector.size(); i++)
	{
		cout << newVector[i] << " ";
	}

	newVector.insert(newVector.begin(), 5);
	cout << "\nThe first element is: " << newVector[0] << endl;

	newVector.erase(newVector.begin());

	for (int i = 0; i < newVector.size(); i++)
	{
		cout << newVector[i] << " ";
	}

	return 0;
}
