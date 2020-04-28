#include "pch.h"
#include "Expression.h"

// Метод для перевірки правильності введених операнд, виконується при введені даних та розрахунку значення виразу.
void Expression::Check()
{
    // Перевірка кореня
    if (isnan(sqrt(41 - d))) { throw 1; }
    // Перевірка дільника
    else if ((sqrt(41 - d) - (b * a) + c) == 0) { throw 2; }
    return;
    //catch (int errIndex) {
    //    if (errIndex == 1) { printf("Квадратний корiнь вiд'ємного числа\n"); }
    //    else if (errIndex == 2) { printf("Дiльник дорiвнює нулю\n"); }
    //}
}

// Метод для розрахунку значення виразу
double Expression::Calculate()
{
    // Викликається перевірка правильності операнд
    Check();
    // Розраховується значення виразу
    return ((a * b / 4) - 1) / (sqrt(41 - d) - (b * a) + c);
}

// Конструктор
Expression::Expression(double aInput, double bInput, double cInput, double dInput)
{
    a = aInput;
    b = bInput;
    c = cInput;
    d = dInput;

    // Викликається перевірка правильності операнд
    Check();
}

// Індексатор для введення-виведення операнд виразу
// Перевіряє правильність операнд при введенні
void Expression::Change(char index, double value)
{
    if (index == 'a') { a = value; }
    else if (index == 'b') { b = value; }
    else if (index == 'c') { c = value; }
    else if (index == 'd') { d = value; }
    else { throw "Символ не відповідає жодному з операнд виразу."; }

    // Викликається перевірка правильності операнд
    Check();
}
