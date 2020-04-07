#include <iostream>
#include <string>
#include <cmath>
using namespace std;

class Trapezoid 
{
	int coord[8];
	public:
		Trapezoid()
		{
			for (int i = 0; i < 8; i++)
			{
				coord[i] = 0;
			}
		}
		int getValue(int ind)
		{
			return coord[ind];
		}
		Trapezoid(Trapezoid & copy) 
		{
			for (int i = 0; i < 8; i++) 
			{
				coord[i] = copy.getValue(i);
			}
		}
		Trapezoid(int c[8])
		{
			for (int i = 0; i < 8; i++)
			{
				coord[i] = c[i];
			}
		}
		
		const int  operator[](const int index) {
			return coord[index];
		}
		
		Trapezoid operator + (Trapezoid c1)
		{
			int temp[8];
			for (int i = 0; i < 8; i++) 
			{
				temp[i] = coord[i] + c1[i];
			}
			Trapezoid t(temp);
			return t;
		}

		Trapezoid operator - (int c1)
		{
			for (int i = 0; i < 8;i++) 
			{
				coord[i] -= c1;
			}
			return *this;
		}
		Trapezoid operator * (Trapezoid t )
		{
			for (int i = 0; i < 8; i++)
			{
				coord[i] *= t[i];
			}
			return *this;
		}

		Trapezoid operator=(Trapezoid mc)
		{
			for (int i = 0; i < 8; i++)
			{
				coord[i] = mc[i];
			}
			return *this;
		}
		Trapezoid  operator / (Trapezoid   c1)
		{
			int temp[8];
			for (int i = 0; i < 8; i++)
			{
				temp[i] = coord[i] / c1[i];
			}
			Trapezoid t(temp);
			return t;
		}
		float Perimetr()
		{
			int x1, y1, x2, y2,x3,y3,x4,y4;
			x1 = coord[0];
			y1 = coord[1];
			x2 = coord[2];
			y2 = coord[3];
			x3 = coord[4];
			y3 = coord[5];
			x4 = coord[6];
			y4 = coord[7];
			float AB = sqrt(pow((x2 - x1), 2) + pow((y2 - y1), 2));
			float BC = sqrt(pow((x3 - x2), 2) + pow((y3 - y2), 2));
			float CD = sqrt(pow((x4 - x3), 2) + pow((y4 - y3), 2));
			float AD = sqrt(pow((x1 - x4), 2) + pow((y1 - y3), 2));
			return (AB+BC+CD+AD);
		}
		float Ploshad() 
		{
			int x1, y1, x2, y2, x3, y3, x4, y4;
			x1 = coord[0];
			y1 = coord[1];
			x2 = coord[2];
			y2 = coord[3];
			x3 = coord[4];
			y3 = coord[5];
			x4 = coord[6];
			y4 = coord[7];
			float A = sqrt(pow((x2 - x1), 2) + pow((y2 - y1), 2));
			float B = sqrt(pow((x3 - x2), 2) + pow((y3 - y2), 2));
			float C = sqrt(pow((x4 - x3), 2) + pow((y4 - y3), 2));
			float D = sqrt(pow((x1 - x4), 2) + pow((y1 - y3), 2));
			float square = ((A + B) / 2)*sqrt ( pow(C,2) - pow((pow(B - A,2) +pow(C,2)-pow(D,2) )/(2*(B-A)),2));
			return square;
		}
		void Show(string name) 
		{
			cout << "Данные о трапеции "+name+": " << endl;
			cout << '[' << coord[0] << ',' << coord[1] << ']' << '[' << coord[2] << ',' << coord[3] << ']' << '[' << coord[4] << ',' << coord[5] << ']' << '[' << coord[6] << ',' << coord[7] << ']' << endl;
			/*cout << "Периметр - " << Perimetr() << endl;
			cout << "Площадь - " << Ploshad() << endl;*/
		}
};

int main()
{
	setlocale(LC_ALL, "");
	int mass[8] = {0,1,2,5,3,7,4,8};
	Trapezoid TR1;
	Trapezoid TR2(mass);
	Trapezoid TR3(TR2);
	cout << "Уменьшим TR1 на 3 единицы" << endl;
	TR1.Show("TR1");
	TR1 - 3;
	TR1.Show("TR1");
	cout << "Умножим TR2 на TR3" << endl;
	TR2.Show("TR2");
	TR2*TR3;
	TR2.Show("TR2");
	TR1 = TR2;
	cout << "Запишем значение TR2 в TR1" << endl;
	TR1.Show("TR1");
	return 0;
}
