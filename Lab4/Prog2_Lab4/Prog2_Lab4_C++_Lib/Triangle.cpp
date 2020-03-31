#include "pch.h"
#include "Triangle.h"

// Метод отримання даних (точок) трикутника
vector<vector<int>> Triangle::Get() {
	return points;
};

// Перевантажений метод отримання даних трикутника, повертає одне значення матриці точок
// Використовується в функції виведення значень на екран, в основній програмі
int Triangle::Get(int i, int j) {
	return points[i][j];
};

// Ініціалізатор, використовується в усіх конструкторах класу
// Задає розмір вектора
// 3 точки, 2 виміри
void Triangle::_Init() {
	points.assign(3, { 0, 0 });
}

// Конструктор за умовченням
Triangle::Triangle() {
	_Init();

	points = { {1, 0}, {0, 1}, {0, 0} };
}

// Конструктор з памаметром
Triangle::Triangle(int (*input)[2]) {
	_Init();

	for (int i = 0; i < 3; i++) {
		for (int j = 0; j < 2; j++) {
			points[i][j] = input[i][j];
		}
	}
}

// Конструктор копіювання
Triangle::Triangle(Triangle& input) {
	points = input.Get();
}

// Метод обчислення відстанні між точками трикутника
// Приватний метод, використовується для розрахунку периметра
float Triangle::Length(int i1, int i2) {
	if (i1 == -1) { i1 = 2; }
	vector<int> a(2); 
	vector<int> b(2); 

	for (int i = 0; i < 2; i++) {
		a[i] = points[i1][i];
		b[i] = points[i2][i];
	}

	return sqrtf(pow((double(a[0]) - double(b[0])), 2) + pow((double(a[1]) - double(b[1])), 2));
};

// Метод обчислення периметра
float Triangle::Perimeter() {
	float peri = 0;
	for (int i = 0; i < 3; i++)
	{
		peri += Length(i - 1, i);
	}
	return peri;
};

// Метод обчислення площі
float Triangle::Area() { 
	return (float(abs(points[0][0] * (points[1][1] - points[2][1])) + abs(points[1][0] * (points[2][1] - points[0][1])) + abs(points[2][0] * (points[0][1] - points[1][1]))) / 2);
};

// Переватнаження оператору додавання
// Додає координати відпоівдних точок двох трикутників
Triangle Triangle::operator+(Triangle bTri)
{
	int result[3][2];

	vector<vector<int>> b = bTri.Get();

	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			result[i][j] = points[i][j] + b[i][j];
		}
	}
	Triangle tri(result);
	return tri;
}

// Переватнаження оператору множення
// Множить всі координати трикутника на дане число
Triangle Triangle::operator*(int b)
{
	int result[3][2];

	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			result[i][j] = points[i][j] * b;
		}
	}
	Triangle tri(result);
	return tri;
}