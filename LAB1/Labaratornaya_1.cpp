#include <iostream>
#include "library.h"

using namespace std;
using namespace space;

int main()
{
    int number;
    int& ref = number;
    cout << "Enter the number for decrease: ";
    cin >> number;
    Decrease(ref);
    cout << " 1) Decrease result = " << number << endl;

    int A, B;
    cout << "Enter the numbers to compare" << endl;
    cout << "Number A: ";
    cin >> A;
    cout << "Number B: ";
    cin >> B;
    bool result = Compare(A, B);

    if (result)
    {
        cout << " 2) A == B" << endl;
    }
    
    else
    {
        cout << " 2) A != B" << endl;
    }
   
    system("pause");
    return 0;
}