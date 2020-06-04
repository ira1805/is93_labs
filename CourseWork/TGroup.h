#pragma once
#include <string>
#include <iostream>
#include "TStudent.h"

using namespace std;

class TGroup
{
public:
	TGroup();   //конструктор
	TGroup(int new_id_group, string new_group_name);    //конструктор
	void set_id_group(int new_id_group);                //установить ид группы
	void set_group_name(string new_group_name);         //установить название группы
	void add_student(TStudent* new_student);            //добавить студента в список группы
	void delete_student(string second_name);            //удалить студента из группы
	int get_id_group();                                 //получить ид группы
	string get_group_name();                            //получить название группы
	TStudent* get_Student(int id);                      //получить объект студента по его ид
	int get_n_students();                               //получить количество студентов в группе

private:
	int id_group;                     //ид группы
	string group_name;                //название группы
	int n_students;                   //количество студентов в группе
	TStudent* student_list;           //список студентов в группе
};
//---------------------------------------------------------
