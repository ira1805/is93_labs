// CourseWork.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//


#include <iostream>
#include "TMenu.h"
#include "TInputOutput.h"


using namespace std;
struct FullName
{
    string mFirst;
    string mLast;
};


int main() 
{
    setlocale(LC_ALL, "Russian");

    TMenu* menu = new TMenu(); //создаем объект меню
    TInputOutput* io_module = new TInputOutput();

    menu->make_menu();  //запускаем меню в работу
    //cout << "Проверка.  Был выбран пункт меню - " << menu->get_id() << endl;

    io_module->dispatcher(menu->get_id()); 
//
    
    delete menu;  // удалаем объект меню
    delete io_module; //удаляем объект ввода вывода

    system("pause");
    return 0;
}