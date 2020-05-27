#include <iostream>
#include "lib.h"

using namespace std;

void WriteOut(double* input)
{
    for (int i = 0; i < 4; i++)
    {
        cout << input[i];
        cout << ' ';
    }
    cout << '\n';
    return;
}

int main()
{
    printf("Створенний список:");
    lib word = lib(35);
    word.NewHead(25);
    word.NewHead(5);
    word.NewHead(10);
    WriteOut(word.MakeValueArray());
    printf("Видалення елементiв пiсля максимального:");
    word.DelAfterMax();
    WriteOut(word.MakeValueArray());
    printf("Видалення елементiв менших за середнє значення:");
    word.DelBelowAverage();
    WriteOut(word.MakeValueArray());
}
