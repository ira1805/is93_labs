#include "pch.h"
#include "Line.h"



// Конструктор класа
Line::Line(string input)
{
    symbols.assign(input.size(), ' ');

    for (int j = 0; j < input.size(); j++)
    {
        symbols[j] = input[j];
    }
};

// Повертає весь массив, для простоти виводу
vector<char> Line::GetWhole()
{
    return symbols;
}

// Віртуальна функція для визначення довжини рядка
int Line::Length()
{
    return symbols.size();
}

// Віртуальна функція для підрахунку кількості введеного символу
int Line::Count(char target)
{
    int count = 0;
    for (int i = 0; i < symbols.size(); i++)
    {
        if (symbols[i] == target) {
            count++;
        }
    }
    return count;
}

// Віртуальна функція підрахунку буз аргументів
// Так як похідні класи не використовують аргументи, то попередній метод перевантажуються
int Line::Count()
{
    return symbols.size();
}

// Перезапис віртуальної функції підрахунку, рахує кількість символів '*'
int Symbols::Count()
{
    int count = 0;
    for (int i = 0; i < symbols.size(); i++)
    {
        if (symbols[i] == '*')
        {
            count++;
        }
    }
    return count;
}

// Перезапис віртуальної функції підрахунку, рахує кількість символів 'В'
int LargeLetters::Count()
{
    int count = 0;
    for (int i = 0; i < symbols.size(); i++)
    {
        if (symbols[i] == 'В')
        {
            count++;
        }
    }
    return count;
}

