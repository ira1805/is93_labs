#pragma once
#include "vector"

using std::vector;

class Figure {
// protected залишає доступ похідним классам без повного відкриття данних
protected:
	// Точки трикутника - двомірний масив-вектор
	vector<vector<int>> points;

	void _Init(int n);

public:
	vector<vector<int>> Get();

	int Get(int, int);

	Figure();

	Figure(int(*input)[2]);

	float Length(int, int);
};

class Square : public Figure {
protected:

	void _Init();

public:
	Square(int[4][2]);

	float Perimeter();

	float Area();
};