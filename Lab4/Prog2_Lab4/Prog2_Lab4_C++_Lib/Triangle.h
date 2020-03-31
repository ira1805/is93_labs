#pragma once
#include "vector"

using std::vector;

class Triangle
{
private:
	// Точки трикутника - двомірний масив-вектор
	vector<vector<int>> points;
	
	void _Init();
	
	float Length(int, int);

public:
	vector<vector<int>> Get();

	int Get(int, int);

	Triangle();

	Triangle(int (*input)[2]);

	Triangle(Triangle&);

	float Perimeter();

	float Area();

	Triangle operator + (Triangle);

	Triangle operator * (int);
};

