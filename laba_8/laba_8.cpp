#include <iostream>
#include <ctime>
#include <math.h>
#include <stdio.h>


using namespace std;

int main()

{
    setlocale(LC_ALL, "rus");
    srand(time(NULL));

    int ryad_Num, stolb_Num, min_znach, max_znach; // переменные

    cin >> ryad_Num;   // вносим значения
    cin >> stolb_Num;
    cin >> min_znach;
    cin >> max_znach;

    int** iArray = new int* [ryad_Num];   // создаем динам. массив
    for (int i = 0; i < ryad_Num; ++i) {
        iArray[i] = new int[stolb_Num];
        for (int j = 0; j < stolb_Num; ++j) {
            iArray[i][j] = min_znach + rand() % (max_znach - min_znach);   // заполняем случ. значениями
            cout << iArray[i][j] << " | ";          // выводим в виде таблицы
        }
        cout << endl;
    }

    for (int i = 0; i < ryad_Num; ++i) {
        int sum = 0;          // переменная для накопления суммы строки
        for (int j = 0; j < stolb_Num; ++j) {
            sum += iArray[i][j];
        }
        cout << "Сумма" << i + 1 << " ой строки: " << sum << endl;
    }

    for (int i = 0; i < ryad_Num; ++i) {         // высвобождаем память
        delete iArray[i];
    }
    delete[] iArray;

    system("pause");
}