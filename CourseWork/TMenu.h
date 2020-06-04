#pragma once

using namespace std;
#include <iostream>

//���������� ���������
#define EXIT_FROM_PROGRAM 4
#define RETURN_MAIN_MENU 9

//���������� ������, ������� ��������� ���� ���� �������
class TMenu
{
	public:
		TMenu();      //�����������
		int get_id(); //�������� ��� ����
		void make_menu();  //�������� ����� ���������� ���� ���� �������

	private:
		int id_menu; //��� ���������� ������ ����

		void show_main_menu(); //�������� ������� ���� ������� ������
		void show_submenu1();  //�������� �������
		void show_submenu2();  //�������� �������
		void show_submenu3();  //�������� �������
};