#include <iostream>
#include "Cusque.h"

using namespace std;
int main()
{
    setlocale(LC_ALL, "Russian");
    printf("Стеблянко Олександр, Лабораторна 7, Варiант 9 \n");

    printf("Створення списку:");
    Cusque word = Cusque(10);
    word.NewHead(20);
    word.NewHead(30);
    word.NewHead(5);
    WriteOut(word.MakeValueArray());

    printf("Видалення елементiв пiлся максимального:");
    word.ElimAfterMax();
    WriteOut(word.MakeValueArray());

    printf("Видалення елементiв менших за середнє значення:");
    word.ElimBelowAverage();
    WriteOut(word.MakeValueArray());
}

// Метод для виведення вешрин квадрату на екран. Поза класу бо використовує консоль.
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