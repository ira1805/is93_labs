#include<iostream>
#include"Figures.h"
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    cout<<"Samilenko Oleksandr IS-93\n";
    double x1, y1, x2, y2, x3, y3, x4, y4;
    cout<<"¬ведите координаты дл€ пр€моугольника(ќбход фигуры делать за или против часовой стрелки!):\n";
    cout<<"¬ведите координаты 1-й вершины(в 2-х мерном пространстве):\n";
    cout<<"x1 = ";
    cin >> x1;
    cout << "y1 = ";
    cin >> y1;
    cout << "¬ведите координаты 2-й вершины(в 2-х мерном пространстве):\n";
    cout << "x2 = ";
    cin >> x2;
    cout << "y2 = ";
    cin >> y2;
    cout << "¬ведите координаты 3-й вершины(в 2-х мерном пространстве):\n";
    cout << "x3 = ";
    cin >> x3;
    cout << "y3 = ";
    cin >> y3;
    cout << "¬ведите координаты 4-й вершины(в 2-х мерном пространстве):\n";
    cout << "x4 = ";
    cin >> x4;
    cout << "y4 = ";
    cin >> y4;
    Rectangle value (x1, y1, x2, y2, x3, y3, x4, y4);//Make example class of Rectangle
    cout << "ѕерuметр пр€моугольника = " << value.GetPerimetr()<<endl;//Output perimetr
    cout << "ѕлощадь пр€моугольника = " << value.GetPloscha() << endl;//Output area
	system("pause");
	return 0;
}