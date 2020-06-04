//���� ���������� ������ ����

using namespace std;

#include "TMenu.h" //���������� ���� ���������� ����

//�����������
TMenu::TMenu()
{
	id_menu = 0;
}
//-----------------------------------------------------

int TMenu::get_id() //�������� ��� ����
{
	return id_menu;
}

//--------------------------------------------------------

void TMenu::show_main_menu() //�������� ������� ���� ������� ������
{
    bool success = false; // ���������� ����� ���� ����

    while (!success)
        {
            system("cls"); // ������� �����
            cout << "-------------------------" << endl;
            cout << "������� ����" << endl;
            cout << "-------------------------" << endl;
            cout << "1 ���������� ���i����i�" << endl;
            cout << "2 ������" << endl;
            cout << "3 ���������� ��i�i�" << endl;
            cout << "4 ���i�" << endl;
            cout << "����i�� ��� ���i�: ";

            cin >> id_menu;  //�������� ���

            if ((id_menu < 1) || (id_menu > 4))  //�������� ���������
            {
                cout << "������� ���i����� ����� ����" << endl;
                success = false;
            }
            else
                success = true;
        }
}
//------------------------------------------------------------

void TMenu::show_submenu1()  //�������� ������� 1
{
    bool success = false; // ���������� ����� ���� ����

    while (!success)
        {
            cout << endl;
            cout << "--------------------------------" << endl;
            cout << "11 �������� ��������" << endl;
            cout << "12 �������� ���������" << endl;
            cout << "13 �������� �����" << endl;
            cout << "14 �������� �������i��" << endl;
            cout << "15 �������� ����i����i���" << endl;
            cout << "16 �������� �������" << endl;
            cout << "17 �������� �������" << endl;
            cout << "9  ����������� �� ��������� ����" << endl;
            cout << "����i�� ��� ���i�: ";

            cin >> id_menu;  //�������� ���
            if (id_menu == RETURN_MAIN_MENU) return;
            if ((id_menu < 11) || (id_menu > 17))  //�������� ���������
            {
                cout << "������� ���i����� ����� ����" << endl;
                cout << "����i�� ��� ���i�: ";
                success = false;
            }
            else
                success = true;
        }
}
//-----------------------------------------------------------------

void TMenu::show_submenu2()  //�������� ������� 2
{
    bool success = false; //���������� ����� ���� ����

        while (!success)
        {
            cout << endl;
            cout << "--------------------------------" << endl;
            cout << "21 ���������� ��������" << endl;
            cout << "22 ���������� ���������" << endl;
            cout << "23 ���������� �����" << endl;
            cout << "24 ���������� �������i��" << endl;
            cout << "25 ���������� ����i����i���" << endl;
            cout << "26 ���������� �������" << endl;
            cout << "27 ���������� �������" << endl;
            cout << "9  ����������� �� ��������� ����" << endl;
            cout << "����i�� ��� ���i�: ";

            cin >> id_menu;  //�������� ���
            if (id_menu == RETURN_MAIN_MENU) return;
            if ((id_menu < 21) || (id_menu > 28))  //�������� ���������
            {
                cout << "������� ���i����� ����� ����" << endl;
                cout << "����i�� ��� ���i�: ";
                success = false;
            }
            else
                success = true;
        }
}
//-----------------------------------------------------------------

void TMenu::show_submenu3()  //�������� ������� 3
{
    bool success = false; //���������� ����� ���� ����

        while (!success)
        {
            cout << endl;
            cout << "--------------------------------" << endl;
            cout << "31 ��i� - ������ �������i�" << endl;
            cout << "32 ��i� - ������ ������" << endl;
            cout << "33 ��i� - �������" << endl;
            cout << "34 ��i� - ������ ��������i�" << endl;
            cout << "35 ��i� - ��c����i��" << endl;
            cout << "9  ����������� �� ��������� ����" << endl;
            cout << "����i�� ��� ���i�: ";

            cin >> id_menu;  //�������� ���
            if (id_menu == RETURN_MAIN_MENU) return;
            if ((id_menu < 31) || (id_menu > 35))  //�������� ���������
            {
                cout << "������� ���i����� ����� ����" << endl;
                cout << "����i�� ��� ���i�: ";
                success = false;
            }
            else
                success = true;
        }
}
//-----------------------------------------------------------------

void TMenu::make_menu()  //�������� ����� ���������� ���� ���� �������
{
    bool success = false;  //���������� ����� ���� ����

    while (!success)
        {
            show_main_menu(); //�������� ������� ����
            if ((get_id() == EXIT_FROM_PROGRAM)) exit(0); //����� �� ��������� 
            
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
