#pragma once

#include "THuman.h"

class TStudent : public THuman
{
public:
	TStudent(); //�����������
	TStudent(int new_id_group, //�� ������
		int new_id_specialty,  //�� �������������
		string new_n_record_book, //����� �������
		int new_admission_year,   //��� �����������
		int new_id_human, //�� ��������
		int new_year,     //��� ��������
		string new_name,  //���
		string new_second_name,  //�������
		string new_address,  //�����
		string new_passport, //�������
		string new_phone_number); //����� ��������
	void set_id_group(int new_id_group);
	void set_id_specialty(int new_id_specialty);
	void set_n_record_book(string new_n_record_book);
	void set_admission_year(int new_admission_year);
	void set_next_student(TStudent* next);    //���������� ��������� �� ���������� �������� � ������ ������

	int get_id_group();
	int get_id_specialty();
	string get_n_record_book();
	int get_admission_year();
	TStudent* get_next_student();    //�������� ��������� �� ���������� �������� � ������ ������

private:
	int id_group; //�� ������
	int id_specialty;  //�� �������������
	string n_record_book; //����� �������
	int admission_year;   //��� �����������
	TStudent* next_student; //��������� �� ���������� �������� � ������ ���������
};
//---------------------------------------------------------------------