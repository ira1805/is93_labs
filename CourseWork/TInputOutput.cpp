
#include "TInputOutput.h"

using namespace std;

void TInputOutput::show_file(string fname) 
{
	string line;

	inp_f.open(fname);

	if (!inp_f.is_open())
	{
		cout << "���� �� ������" << endl;
		return;
	}

	while (!inp_f.eof())
	{
		inp_f >> line;
		for (int i = 0; i < line.length(); i++) if (line[i] == '/') line[i] = ' ';
		cout << line << endl;
	}

	inp_f.close();
}
//------------------------------------------------------------------

string TInputOutput::make_new(string header, string mask) //���� ������ ������ ��������
{
	string tmp;

	cout << "=============================" << endl;
	cout << header << endl;
	cout << mask << endl;
	cout << "->";
	cin >> tmp;
	return tmp; //��������� ����� 
}
//------------------------------------------------------------------

void TInputOutput::edit(string fname, string id, string new_line) //�������������� 15 ������ ������
{
	string line;
	string tmp;
	int i;

	inp_f.open(fname);
	out_f.open("f_tmp");//��������� ���� �� ������

	if (!inp_f.is_open())
	{
		cout << "���� �� ������" << endl;
		return;
	}

	while (!inp_f.eof()) 
	{
		inp_f >> line;
		i = 0;
		tmp = "";
		while (line[i] != '/') 
			{
				tmp += line[i]; 
				i++;
			}

		if (tmp != id)
			out_f << line << endl;
		else
			out_f << new_line << endl;
	}

	inp_f.close();
	out_f.close();

	const char *char_str;
	char_str = fname.c_str();
	remove(char_str);
	rename("f_tmp", char_str); //��������������� ����
}
//--------------------------------------------------------------


void TInputOutput::add_new(string fname, string new_string)
{
	out_f.open(fname, std::ios_base::app); //���� ������������

	if (!out_f.is_open())
	{
		cout << "���� �� ������" << endl;
		return;
	}

	out_f << new_string << endl;
	out_f.close();
}
//------------------------------------------------------------------

void TInputOutput::dispatcher(int menu_id)
{
	string s;

	switch (menu_id)
	{
	case 11 :   //11 �������� ��������
		{
		s = make_new("�������� ������ ��������", "[�������]/[���]/[�� �������]/[�� ����������]/[id_������������]/[�����]/[� ������� �����]");
		add_new("Students.txt", s); break; //11 �������� ��������
		}; break;
	case 21:   //21 ���������� ��������
		s = make_new("������������� ��������", "[�������]/[���]/[�� �������]/[�� ����������]/[id_������������]/[�����]/[� ������� �����]");
		edit("Students.txt", "15", s); break; // 15 ��� ��, ��� �� ����������� ��������
	case 31 :
		show_file("Students.txt"); break; //31 ��i� - ������ ���������
	case 32 :
		show_file("Audiences.txt"); break; //32 ��i� - ������ ������
	case 33:
		show_file("Schedule.txt"); break; //33 ��i� - �������
	case 34:
		show_file("Teachers.txt"); break; //34 ��i� - ������ ��������i�
	case 35:
		show_file("Disciplines.txt"); break; //35 ��i� - ��c����i��

	}
}
//----------------------------------------------------------------------
