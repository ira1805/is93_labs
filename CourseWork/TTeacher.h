#pragma once

#include "THuman.h"

class TTeacher : THuman
{
public:
	TTeacher(); //�����������
	TTeacher(int new_id_teacher,
		     int new_id_discipline,
		     int new_audience,
			 string new_department,
			 string new_academic_rank,
		 	int new_id_human, //�� ��������
			int new_year,     //��� ��������
			string new_name,  //���
			string new_second_name,  //�������
			string new_address,  //�����
			string new_passport, //�������
			string new_phone_number //����� ��������
			);

	void set_id_teacher(int new_id_teacher);
	void set_id_discipline(int new_id_discipline);
	void set_the_audience(int new_the_audience);
	void set_department(string new_department);
	void set_academic_rank(string new_academic_rank);

	int get_id_teacher();
	int get_id_discipline();
	int get_the_audience();
	string get_departmemt();
	string get_academic_rank();

private:
	int id_teacher;
	int id_discipline;
	int the_audience;
	string department;
	string academic_rank;
};
//-----------------------------------------------------------------------