#include <iostream>
using namespace std;

void plus_one(int &a);

bool lesser_than(int a, int b);

int main()
{
    
    setlocale(LC_ALL, "Russian");
    int firstnum, secnum, thirdnum;
    cout << "Введите число для операції +1: ";
    cin >> firstnum;
    plus_one(firstnum);
    cout << firstnum;
    
    cout << "Введите перше число для операції <: ";
    cin >> secnum;
    cout << "Введите друге число для операції <: ";
    cin >> thirdnum;
    cout << "Відношення <: " << lesser_than(secnum, thirdnum);
}

void plus_one(int &a) {
    int sign = a >> 15;
    for (int i = 0; i <= 15; i++) {
        int bit = a & (1 << i);
        a ^= (1 << i);
        // cout << a << "\n";
        if ((sign == -1 && bit == (1 << i)) || (sign == 0 && bit == 0)) { return; }
    }
}

bool lesser_than(int a, int b) {
    int bitA = a >> 15; 
    int bitB = b >> 15;
    if (bitA != bitB)
        return bitA;
    else
        for (int i = 14; i >= 0; i--) {
            bitA = (a >> i) & 1;
            bitB = (b >> i) & 1;
            if (bitA != bitB)
                return bitB;
        }
    return 0;
};