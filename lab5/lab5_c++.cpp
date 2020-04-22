#include<iostream>
#include <math.h>
using namespace std;

class Figure 
{
public :
	double coord[2][4];
	Figure() 
	{
		for (int i = 0; i < 2; i++) {
			for (int j = 0; j < 4; j++)
				coord[i][j] = 0;
		}
	}
	Figure(int c[2][4]) 
	{
		for (int i = 0; i < 2; i++) {
			for (int j = 0; j < 4; j++)
				coord[i][j] = c[i][j];
		}
	}
	double dlinaStoroni() 
	{
		return 	sqrt(pow((coord[0][1] - coord[0][0]), 2) + pow((coord[1][1] - coord[1][0]), 2));
	}
};


class Romb :public Figure 
{
public:
	Romb(): Figure()
	{
		for (int i = 0; i < 2; i++) {
			for (int j = 0; j < 4; j++)
				coord[i][j] = 0;
		}
	}
	Romb(int c[2][4])
	{
		for (int i = 0; i < 2; i++) {
			for (int j = 0; j < 4; j++)
				coord[i][j] = c[i][j];
		}
	}
	double ploshad() 
	{
		int dd1 = sqrt(pow((coord[0][2] - coord[0][0]), 2) + pow((coord[1][2] - coord[1][0]), 2));
		int dd2= sqrt(pow((coord[0][3] - coord[0][1]), 2) + pow((coord[1][3] - coord[1][1]), 2));
		return (dd1*dd2) / 2;
	}
	double Periment() 
	{
		return 4 * dlinaStoroni();
	}
	void Show() 
	{
		for (int i = 0; i < 4; i++) 
		{
			cout << "[ "<< coord[0][i]<<","<<coord[1][i]<<"]" << endl;
		}
	}
	double get(int i, int j) 
	{
		return coord[i][j];
	}
};

int main() 
{
	setlocale(LC_ALL, "Rus");
	int c[2][4];
	for (int i = 0; i < 2; i++) 
	{
		for (int j = 0; j < 4; j++) 
		{
			c[i][j] = i + j;
		}
	}
	Romb r(c);
	r.Show();
	cout << "Периметр - " << r.Periment() << " , площадь - " << r.ploshad() << endl;
	return 0;
}
