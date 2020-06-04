
#include "TInputOutput.h"

using namespace std;

void TInputOutput::show_file(string fname) 
{
	string line;

	inp_f.open(fname);

	if (!inp_f.is_open())
	{
		cout << "Файл не открыт" << endl;
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

string TInputOutput::make_new(string header, string mask) //кого хочешь нового выводишь
{
	string tmp;

	cout << "=============================" << endl;
	cout << header << endl;
	cout << mask << endl;
	cout << "->";
	cin >> tmp;
	return tmp; //возращает новое 
}
//------------------------------------------------------------------

void TInputOutput::edit(string fname, string id, string new_line) //редактирование 15 строка пример
{
	string line;
	string tmp;
	int i;

	inp_f.open(fname);
	out_f.open("f_tmp");//временный файл на запись

	if (!inp_f.is_open())
	{
		cout << "Файл не открыт" << endl;
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
	rename("f_tmp", char_str); //переименовываем файл
}
//--------------------------------------------------------------


void TInputOutput::add_new(string fname, string new_string)
{
	out_f.open(fname, std::ios_base::app); //файл открываеться

	if (!out_f.is_open())
	{
		cout << "Файл не открыт" << endl;
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
	case 11 :   //11 Створити студента
		{
		s = make_new("Добавить нового студента", "[прізвище]/[ім’я]/[по батькові]/[рік народження]/[id_спеціальності]/[група]/[№ залікова книги]");
		add_new("Students.txt", s); break; //11 Створити студента
		}; break;
	case 21:   //21 Редагувати студента
		s = make_new("Редактировать студента", "[прізвище]/[ім’я]/[по батькові]/[рік народження]/[id_спеціальності]/[група]/[№ залікова книги]");
		edit("Students.txt", "15", s); break; // 15 это ид, где мы редактируем студента
	case 31 :
		show_file("Students.txt"); break; //31 Звiт - список студентов
	case 32 :
		show_file("Audiences.txt"); break; //32 Звiт - список занять
	case 33:
		show_file("Schedule.txt"); break; //33 Звiт - розклад
	case 34:
		show_file("Teachers.txt"); break; //34 Звiт - список викладачiв
	case 35:
		show_file("Disciplines.txt"); break; //35 Звiт - диcциплiна

	}
}
//----------------------------------------------------------------------
