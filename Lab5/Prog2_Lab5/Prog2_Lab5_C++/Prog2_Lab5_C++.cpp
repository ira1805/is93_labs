#include <iostream>
#include "Figure.h"
#include "Line.h"

using namespace std;

void WriteOut(Square);

void WriteOut(Line);

void main()
{
    setlocale(LC_ALL, "Russian");
    printf("Стеблянко Олександр, Лабораторна 4, Варіант 9 \n");

    printf("Створений квадрат A: \n");
    Square A(new int[4][2]{ { 3, 0 }, { 3, 3 }, { 0, 3 }, { 0, 0 } });
    WriteOut(A);
    cout << '\n';

    printf("Довжина мiж точками: \n");
    cout << A.Length(0, 1) << '\n';
    printf("Периметр квадратy A: \n");
    cout << A.Perimeter() << '\n';
    printf("Площа квадратy A: \n");
    cout << A.Area() << '\n' << '\n';

    printf("Створений квадрат A: \n");
    Symbols B("*$£&)(_*^^#");
    WriteOut(B);
    cout << '\n';

    printf("Довжина лiнiї символiв B: \n");
    cout << B.Length() << '\n';
    printf("Кiлькiсть символу *: \n");
    cout << B.Count() << '\n' << '\n';

    printf("Створений квадрат A: \n");
    LargeLetters C("ФПВЕНРВТУЕВ");
    WriteOut(C);
    cout << '\n';

    printf("Довжина лiнiї великих лiтер C: \n");
    cout << C.Length() << '\n';
    printf("Кiлькiсть символу В: \n");
    cout << C.Count() << '\n' << '\n';
}

// Метод для виведення вешрин квадрату на екран. Поза класу бо використовує консоль.
void WriteOut(Square input)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            cout << input.Get(i, j);
            cout << ' ';
        }
        cout << '\n';
    }
    cout << '\n';
    return;
}

// Метод для виведення рядка на екран. Працює для похідних класів Symbols і LargeLetters.
void WriteOut(Line input)
{
    vector<char> line = input.GetWhole();
    for (int j = 0; j < input.Length(); j++)
    {
        cout << line[j];
    }
    cout << '\n';
    return;
}