#pragma once

using namespace std;
#include <iostream>

//определить константы
#define EXIT_FROM_PROGRAM 4
#define RETURN_MAIN_MENU 9

//объявление класса, который управляет меню всех уровней
class TMenu
{
	public:
		TMenu();      //конструктор
		int get_id(); //получить код меню
		void make_menu();  //основной метод управления меню всех уровней

	private:
		int id_menu; //код выбранного пункта меню

		void show_main_menu(); //показать главное меню первого уровня
		void show_submenu1();  //показать подменю
		void show_submenu2();  //показать подменю
		void show_submenu3();  //показать подменю
};