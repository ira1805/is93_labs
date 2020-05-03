#include "pch.h"
#include "Expression.h"

// Метод для перевірки правильності введених операнд, виконується при введені даних та розрахунку значення виразу.
void Expression::Check()
{
    try {
        // Перевірка кореня
        if (isnan(sqrt(41 - d))) { throw "Квадратний корiнь вiд'ємного числа"; }
        // Перевірка дільника
        else if ((sqrt(41 - d) - (b * a) + c) == 0) { throw "Дiльник дорiвнює нулю"; }
        return;
    }
    catch (char* errMessage) {
        throw std::runtime_error(errMessage);
    }
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
    try {
        switch (index) {
        case 'a': a = value; break;
        case 'b': b = value; break;
        case 'c': c = value; break;
        case 'd': d = value; break;
        default: throw "Символ не відповідає жодному з операнд виразу."; break;
        }
    }
    catch (char* errMessage) {
        throw std::invalid_argument(errMessage);
    }

    // Викликається перевірка правильності операнд
    Check();
}
