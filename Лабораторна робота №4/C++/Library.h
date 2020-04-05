#pragma once
#include<string>
#include<vector>
namespace New_Library
{
    class Library
    {
    public:int length;// довжина
    private: std::vector<char> str;//  рядок
    public:Library();//Конструктор за замовчунням
    public:Library(std::vector<char> str);//Конструктор з параметрами
    public:Library(Library&);//Конструктор копіювання
    private: void LENGTH(std::vector<char> str);//Метод для знаходження довжини рядка
    public:std::vector<char> GetStr();//Метод для повернення рядка
    public:Library operator +(Library right_val);//Оператор для додавання двох рядків
    public:Library operator /(int b);//Оператор для ділення рядка
    private: void Init();//Ініціалізація за замовченням
    };
}