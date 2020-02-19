#include <iostream>
using namespace std;
void Pruriv(int x, int y)
{
    if ((x ^ y) != 0)
    {
        cout << "Першi числа Нерiвнi" << endl;
    }
    else {
        cout << "Першi числа Рiвнi" << endl;
    }
}
int Suma_Bit(int a,int b)
{
    int counter;
    while (b != 0) {
        counter = a & b;
        a = a ^ b;
        b = counter << 1;
    }
    return a;
}