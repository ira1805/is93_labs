#include <iostream>
#include "Triangle.h"

using namespace std;

void WriteOut(Triangle);

int main()
{
    setlocale(LC_ALL, "Russian");
    cout << "Стеблянко Олександр, Лабораторна 4, Завдання 9 \n \n";

    cout << "Точки трикутника Т1, створеного констр. за замовчуванням: \n";
    Triangle T1;
    WriteOut(T1);
    cout << "Точки трикутника Т2, створеного констр. з параметрами: \n";
    Triangle T2(new int[3][2]{ { 2, 3 }, { 5, -6 }, { 0, 1 } });
    WriteOut(T2);
    cout << "Точки трикутника Т3, створеного констр. копiювання: \n";
    Triangle T3(T1);
    WriteOut(T3);

    cout << "Периметр трикутника Т2: \n";
    cout << T2.Perimeter();
    cout << '\n';
    cout << "Площа трикутника Т2: \n";
    cout << T2.Area();
    cout << "\n \n";

    cout << "Точки трикутника Т3 пiсля множення на 2: \n";
    T3 = T3 * 2;
    WriteOut(T3);

    cout << "Точки трикутника Т1, що дорiвнює сумi Т1 та Т2: \n";
    T1 = T3 + T2;
    WriteOut(T1);

    cout << "Спробуємо створити трикутник з точками на одній лінії:";
    Triangle Err(new int[3][2]{ { 1, 1 }, { 2, 2 }, { 3, 3 } });
    WriteOut(Err);
}

// Функція для виведення масиву на екран. Поза класу бо використовує консоль.
void WriteOut(Triangle input)
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