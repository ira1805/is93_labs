#include <math.h>
#include <string>
using namespace std;

class Figures
{
public:
	virtual double S() { return 0; }
	virtual double P() { return 0; }
};

class Rhombus : public Figures
{
private:
	double x1, y1, x2, y2, x3, y3, x4, y4;

public:
	Rhombus(double A[], double B[], double C[], double D[])
	{
		x1 = A[0];
		y1 = A[1];
		x2 = B[0];
		y2 = B[1];
		x3 = C[0];
		y3 = C[1];
		x4 = D[0];
		y4 = D[1];
	}

	double S()
	{
		return 0.5 * (sqrt(pow(x3 - x1, 2) + pow(y3 - y1, 2))) * (sqrt(pow(x4 - x2, 2) + pow(y4 - y2, 2)));
	}

	double P()
	{
		return 4 * (sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2)));
	}
};

class Circle : public Figures
{
private:
	double radius;

public:
	Circle(double rad)
	{
		radius = rad;
	}

	double GetRad()
	{
		return radius;
	}

	double S()
	{
		return 3.14159 * pow(radius, 2);
	}

	double P()
	{
		return 2 * 3.14159 * radius;
	}
};