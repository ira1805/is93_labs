#include <iostream>

using namespace std;

class Rectangle
{
public:
	float Ax, Ay, Bx, By, Cx, Cy, Dx, Dy;

	Rectangle()
	{
		//Default constructor
	}

	Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
	{
		Ax = x1;
		Ay = y1;
		Bx = x2;
		By = y2;
		Cx = x3;
		Cy = y4;
		Dx = x4;
		Dy = y4;
		//Ñconstructor with parameters
	}

	Rectangle(const Rectangle& Q1)
	{
		Ax = Q1.Ax;
		Ay = Q1.Ay;
		Bx = Q1.Bx;
		By = Q1.By;
		Cx = Q1.Cx;
		Cy = Q1.Cy;
		Dx = Q1.Dx;
		Dy = Q1.Dy;
		//Constructor with copy
	}

	Rectangle operator -(Rectangle& Q2)
	{
		return Rectangle(Ax - Q2.Ax, Ay - Q2.Ay, Bx - Q2.Bx, By - Q2.By, Cx - Q2.Cx, Cy - Q2.Cy, Dx - Q2.Dx, Dy - Q2.Dy);
	}

	Rectangle operator /(int x)
	{
		return Rectangle(Ax / x, Ay / x, Bx / x, By / x, Cx / x, Cy / x, Dx / x, Dy / x);
	}

	double CalculatePerimetrium()
	{
		double AB = sqrt(pow(Bx - Ax, 2) + pow(By - Ay, 2));
		double BC = sqrt(pow(Cx - Bx, 2) + pow(Cy - By, 2));
		return ((AB + BC) * 2);
	}

	double CalculateSquare()
	{
		double AB = sqrt(pow(Bx - Ax, 2) + pow(By - Ay, 2));
		double BC = sqrt(pow(Cx - Bx, 2) + pow(Cy - By, 2));
		return (AB * BC);
	}
	void Print()
	{
		printf("A[%.1f,%.1f], B[%.1f, %.1f], C[%.1f, %.1f], D[%.1f, %.1f]\n", Ax, Ay, Bx, By, Cx, Cy, Dx, Dy);
	}
};

int main()
{
	Rectangle Q1 = Rectangle();                         //default constructor 
	Rectangle Q2 = Rectangle(1, 1, 1, 3, 4, 3, 1, 4);   //constructor with parametrs
	Rectangle Q3 = Rectangle(Q2);                       //constructor with copy 

	Q2 = Q2 / 2;
	cout << "Coordinates for Q2: ";
	Q2.Print();

	Q1 = Q3 - Q2;
	cout << "Coordinates for Q1: ";
	Q1.Print();
	cout << "Perimetrium for rectangle Q1= " << Q1.CalculatePerimetrium() << endl;
	cout << "Square for rectangle Q2 = " << Q2.CalculateSquare() << endl;
}