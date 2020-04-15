#include<iostream>
#include"Figures.h"
using namespace std;

int main()
{
    double x1, y1, x2, y2, x3, y3, x4, y4;
    cout << "Enter first coordinates\n";
    cout << "x1 = ";
    cin >> x1;
    cout << "y1 = ";
    cin >> y1;
    cout << "Enter second coordinates:\n";
    cout << "x2 = ";
    cin >> x2;
    cout << "y2 = ";
    cin >> y2;
    cout << "Enter third coordinates\n";
    cout << "x3 = ";
    cin >> x3;
    cout << "y3 = ";
    cin >> y3;
    cout << "Enter fourth coordinates\n";
    cout << "x4 = ";
    cin >> x4;
    cout << "y4 = ";
    cin >> y4;
    Trepeze value(x1, y1, x2, y2, x3, y3, x4, y4);
    cout << "Perimetr: " << value.Get_Perimetr() << endl;//Perimetr
    cout << "Square: " << value.Get_Square() << endl;//Square
    system("pause");
    return 0;
}