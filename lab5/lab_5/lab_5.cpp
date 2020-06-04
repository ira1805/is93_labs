#include <iostream>

using namespace std;

class Figures
{
public:

	int Ax, Ay, Bx, By, Cx, Cy, Dx, Dy;

	Figures(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
	{
		Ax = x1;
		Ay = y1;
		Bx = x2;
		By = y2;
		Cx = x3;
		Cy = y3;
		Dx = x4;
		Dy = y4;
	}

	double CalculateSide(int x, int y, int a, int b)
	{
		double side = sqrt(pow(a - x, 2) + pow(b - y, 2));
		return side;
	}
};

class Trapeze:Figures
{
public:
	Trapeze(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
		: Figures (x1, y1, x2, y2, x3, y3, x4, y4)
	{
		Ax = x1;
		Ay = y1;
		Bx = x2;
		By = y2;
		Cx = x3;
		Cy = y3;
		Dx = x4;
		Dy = y4;
	}
	double FindPerimetr()
	{
		double AB = CalculateSide(Ax, Ay, Bx, By);
		double BC = CalculateSide(Bx, By, Cx, Cy);
		double CD = CalculateSide(Cx, Cy, Dx, Dy);
		double AD = CalculateSide(Dx, Dy, Ax, Ay);
		return (AB + BC + CD + AD);
	}

	double FindSquare()
	{
		double AB = CalculateSide(Ax, Ay, Bx, By);
		double BC = CalculateSide(Bx, By, Cx, Cy);
		double AD = CalculateSide(Dx, Dy, Ax, Ay);
		double h = sqrt(pow(AB, 2) - pow(((AD - BC) / 2), 2));
		return (AD - BC) / 2 * h;
	} 

	void Print()
	{
		printf("A[%.1f,%.1f], B[%.1f, %.1f], C[%.1f, %.1f], D[%.1f, %.1f]\n", Ax, Ay, Bx, By, Cx, Cy, Dx, Dy);
	}
};

int main()
{
	Trapeze Trapeze1 = Trapeze(0, 1, 3, 3, 5, 3, 7, 0);
	Trapeze1.Print();
	cout << "Perimetr for Trapeze1 = " << Trapeze1.FindPerimetr() << endl;
	cout << "Square for Trapeze1 = " << Trapeze1.FindSquare() << endl;
}
