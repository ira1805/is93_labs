//файл реализации класса меню

using namespace std;

#include "TMenu.h" //подключить свой заговочный файл

//конструктор
TMenu::TMenu()
{
	id_menu = 0;
}
//-----------------------------------------------------

int TMenu::get_id() //получить код меню
{
	return id_menu;
}

//--------------------------------------------------------

void TMenu::show_main_menu() //показать главное меню первого уровня
{
    bool success = false; // успешность ввода кода меню

    while (!success)
        {
            system("cls"); // очищаем экран
            cout << "-------------------------" << endl;
            cout << "Головне меню" << endl;
            cout << "-------------------------" << endl;
            cout << "1 Формування довiдникiв" << endl;
            cout << "2 Робота" << endl;
            cout << "3 Формування звiтiв" << endl;
            cout << "4 Вихiд" << endl;
            cout << "Зробiть Ваш вибiр: ";

            cin >> id_menu;  //получить код

            if ((id_menu < 1) || (id_menu > 4))  //проверка диапазона
            {
                cout << "Введено недiйсний номер меню" << endl;
                success = false;
            }
            else
                success = true;
        }
}
//------------------------------------------------------------

void TMenu::show_submenu1()  //показать подменю 1
{
    bool success = false; // успешность ввода кода меню

    while (!success)
        {
            cout << endl;
            cout << "--------------------------------" << endl;
            cout << "11 Створити студента" << endl;
            cout << "12 Створити викладача" << endl;
            cout << "13 Створити групу" << endl;
            cout << "14 Створити дисциплiну" << endl;
            cout << "15 Створити спецiальнiсть" << endl;
            cout << "16 Створити заняття" << endl;
            cout << "17 Створити розклад" << endl;
            cout << "9  Повернутися до головного меню" << endl;
            cout << "Зробiть Ваш вибiр: ";

            cin >> id_menu;  //получить код
            if (id_menu == RETURN_MAIN_MENU) return;
            if ((id_menu < 11) || (id_menu > 17))  //проверка диапазона
            {
                cout << "Введено недiйсний номер меню" << endl;
                cout << "Зробiть Ваш вибiр: ";
                success = false;
            }
            else
                success = true;
        }
}
//-----------------------------------------------------------------

void TMenu::show_submenu2()  //показать подменю 2
{
    bool success = false; //успешность ввода кода меню

        while (!success)
        {
            cout << endl;
            cout << "--------------------------------" << endl;
            cout << "21 Редагувати студента" << endl;
            cout << "22 Редагувати викладача" << endl;
            cout << "23 Редагувати групу" << endl;
            cout << "24 Редагувати дисциплiну" << endl;
            cout << "25 Редагувати спецiальнiсть" << endl;
            cout << "26 Редагувати заняття" << endl;
            cout << "27 Редагувати розклад" << endl;
            cout << "9  Повернутися до головного меню" << endl;
            cout << "Зробiть Ваш вибiр: ";

            cin >> id_menu;  //получить код
            if (id_menu == RETURN_MAIN_MENU) return;
            if ((id_menu < 21) || (id_menu > 28))  //проверка диапазона
            {
                cout << "Введено недiйсний номер меню" << endl;
                cout << "Зробiть Ваш вибiр: ";
                success = false;
            }
            else
                success = true;
        }
}
//-----------------------------------------------------------------

void TMenu::show_submenu3()  //показать подменю 3
{
    bool success = false; //успешность ввода кода меню

        while (!success)
        {
            cout << endl;
            cout << "--------------------------------" << endl;
            cout << "31 Звiт - список студентiв" << endl;
            cout << "32 Звiт - список занять" << endl;
            cout << "33 Звiт - розклад" << endl;
            cout << "34 Звiт - список викладачiв" << endl;
            cout << "35 Звiт - диcциплiна" << endl;
            cout << "9  Повернутися до головного меню" << endl;
            cout << "Зробiть Ваш вибiр: ";

            cin >> id_menu;  //получить код
            if (id_menu == RETURN_MAIN_MENU) return;
            if ((id_menu < 31) || (id_menu > 35))  //проверка диапазона
            {
                cout << "Введено недiйсний номер меню" << endl;
                cout << "Зробiть Ваш вибiр: ";
                success = false;
            }
            else
                success = true;
        }
}
//-----------------------------------------------------------------

void TMenu::make_menu()  //основной метод управления меню всех уровней
{
    bool success = false;  //успешность ввода кода меню

    while (!success)
        {
            show_main_menu(); //показать главное меню
            if ((get_id() == EXIT_FROM_PROGRAM)) exit(0); //выйти из программы 
            
            switch (get_id())
                {
                    case 1: show_submenu1(); break;
                    case 2: show_submenu2(); break;
                    case 3: show_submenu3(); break;
                }
            
            if(get_id() == RETURN_MAIN_MENU)
                success = false;
            else
                success = true;
        }
}
