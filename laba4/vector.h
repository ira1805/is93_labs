#pragma once
#include <vector>
using namespace std;

class MyVector
{
private:
	double len;
	double ang;

public:
	MyVector()   //конструктор за змовчуванням
	{			
		len = 0;
		ang = 0;
	}

	MyVector(double len, double ang)   //конструктор з параметрами
	{	
		this->len = len;
		this->ang = ang;
	}

	MyVector(MyVector& input)  //конструктор копіювання
	{	
		len = input.len;
		ang = input.ang;
	}

	void Povorot(double angle)   //метод повороту на заданий кут
	{ 
		ang += angle;
	}

	double Len()   //метод отримання довжини
	{	
		return len;
	}

	double Ang()   //метод отримання кута
	{	
		return ang;
	}

	MyVector operator=(MyVector z)   //перевантаження оператора присвоєння
	{	
		len = z.len;
		ang = z.ang;
		return *this;
	}

	MyVector operator*=(double x)   //перевантаження оператора множення
	{	
		len = len * x;
		return *this;
	}

	MyVector operator+=(MyVector z)   //перевантаження оператора додавання
	{	
		len += z.len;
		ang += z.ang;
		return *this;
	}

	friend ostream& operator<<(ostream& stream, MyVector z)  //перевантаження оператора виведення
	{
		stream << "радiус = " << z.len << "\nкут = " << z.ang << "°\n\n";
		return stream;
	}
};