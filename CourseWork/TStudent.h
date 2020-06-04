#pragma once

#include "THuman.h"

class TStudent : public THuman
{
public:
	TStudent(); //конструктор
	TStudent(int new_id_group, //ид группы
		int new_id_specialty,  //ид специальности
		string new_n_record_book, //номер зачетки
		int new_admission_year,   //год поступления
		int new_id_human, //ид человека
		int new_year,     //год рождения
		string new_name,  //имя
		string new_second_name,  //фамилия
		string new_address,  //адрес
		string new_passport, //паспорт
		string new_phone_number); //номер телефона
	void set_id_group(int new_id_group);
	void set_id_specialty(int new_id_specialty);
	void set_n_record_book(string new_n_record_book);
	void set_admission_year(int new_admission_year);
	void set_next_student(TStudent* next);    //установить указатель на следующего студента в списке группы

	int get_id_group();
	int get_id_specialty();
	string get_n_record_book();
	int get_admission_year();
	TStudent* get_next_student();    //получить указатель на следующего студента в списке группы

private:
	int id_group; //ид группы
	int id_specialty;  //ид специальности
	string n_record_book; //номер зачетки
	int admission_year;   //год поступления
	TStudent* next_student; //указатель на следующего студента в списке студентов
};
//---------------------------------------------------------------------