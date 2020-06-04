#pragma once
#include <string>
#include <iostream>
#include "TStudent.h"

using namespace std;

class TGroup
{
public:
	TGroup();   //�����������
	TGroup(int new_id_group, string new_group_name);    //�����������
	void set_id_group(int new_id_group);                //���������� �� ������
	void set_group_name(string new_group_name);         //���������� �������� ������
	void add_student(TStudent* new_student);            //�������� �������� � ������ ������
	void delete_student(string second_name);            //������� �������� �� ������
	int get_id_group();                                 //�������� �� ������
	string get_group_name();                            //�������� �������� ������
	TStudent* get_Student(int id);                      //�������� ������ �������� �� ��� ��
	int get_n_students();                               //�������� ���������� ��������� � ������

private:
	int id_group;                     //�� ������
	string group_name;                //�������� ������
	int n_students;                   //���������� ��������� � ������
	TStudent* student_list;           //������ ��������� � ������
};
//---------------------------------------------------------
