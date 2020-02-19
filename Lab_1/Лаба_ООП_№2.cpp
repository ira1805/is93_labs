#include <iostream>
#include "Лаба№1.h"
using namespace std;
int main()
{
    setlocale(LC_ALL, "rus");
    int a, b, x, y, counter,k;
    cout << "Введiть чиcла для порiвняння" << endl;
    cin >> a >> b;
    cout << "Введiть перше число суми" << endl;
    cin >> x;
    cout << "Введiть друге число для суми" << endl;
    cin >> y;
    Pruriv(a, b);
    k=Suma_Bit(x,y);
    cout << "Отримана сума " << k;

}


