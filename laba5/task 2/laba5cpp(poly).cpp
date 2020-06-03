#include <iostream>
#include <string>
#include "classes.h"
using namespace std;

void main()
{
	setlocale(0, "ru");
	cout << "Мулiк Рустам IС-93\n_______________________________________\n\n";
	double A[2] = { 6, 3 };
	double B[2] = { 9, 4 };
	double C[2] = { 10, 7 };
	double D[2] = { 7, 6 };
	Rhombus romb(A, B, C, D);
	Circle krug(5);
	cout << "Координати вершин ромба:\n";
	cout << "A(" << A[0] << ", " << A[1] << ")\n";
	cout << "B(" << B[0] << ", " << B[1] << ")\n";
	cout << "C(" << C[0] << ", " << C[1] << ")\n";
	cout << "D(" << D[0] << ", " << D[1] << ")\n";
	cout << "Радiус кола = " << krug.GetRad() << endl << endl;
	cout << "Площа ромба = " << romb.S() << endl;
	cout << "Периметр ромба = " << romb.P() << endl;
	cout << "Площа круга = " << krug.S() << endl;
	cout << "Довжина кола = " << krug.P() << endl;
	cout << "\n\n\n";
	system("pause");
}