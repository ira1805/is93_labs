#include "pch.h"
#include "Figure.h"

// Метод отримання даних (точок) фігури
vector<vector<int>> Figure::Get() {
	return points;
};

// Перевантажений метод отримання даних фігури, повертає одне значення матриці точок
// Використовується в функції виведення значень на екран, в основній програмі
int Figure::Get(int i, int j) {
	return points[i][j];
};

// Ініціалізатор для фігур
// Задає розмір вектора
void Figure::_Init(int n) {
	points.assign(n, { 0, 0 });
}

// Пустий конструктор для використання підкласами з власними конструкторами
Figure::Figure() {
}

// Конструктор з памаметром
Figure::Figure(int input[4][2]) {
	_Init(4);

	for (int i = 0; i < 4; i++) {
		for (int j = 0; j < 2; j++) {
			points[i][j] = input[i][j];
		}
	}
}

// Метод обчислення відстанні між точками фігури
float Figure::Length(int i1, int i2) {
	if (i1 == -1) { i1 = 3; }
	vector<int> a(2);
	vector<int> b(2);

	for (int i = 0; i < 2; i++) {
		a[i] = points[i1][i];
		b[i] = points[i2][i];
	}

	return sqrtf(pow((double(a[0]) - double(b[0])), 2) + pow((double(a[1]) - double(b[1])), 2));
};

// Ініціалізатор для квадрату, задає розмір вектора
// 4 точки, 2 виміри
void Square::_Init() {
	points.assign(4, { 0, 0 });
}

// Конструктор з памаметром
Square::Square(int input[4][2]) {
	_Init();

	for (int i = 0; i < 4; i++) {
		for (int j = 0; j < 2; j++) {
			points[i][j] = input[i][j];
		}	
	}
}

// Метод обчислення периметра
float Square::Perimeter() {
	float peri = 0;
	for (int i = 0; i < 3; i++)
	{
		peri += Length(i - 1, i);
	}
	return peri;
};

// Метод обчислення площі
float Square::Area() {
	return Length(0, 1) * Length(1, 2);
};