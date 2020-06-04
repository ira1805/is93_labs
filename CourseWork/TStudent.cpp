
#include "TStudent.h"

//конструктор
TStudent::TStudent() : THuman() //конструктор базового класса
{
	id_group = 0;
	id_specialty = 0;
	n_record_book = "";
	admission_year = 0;
	next_student = NULL;
}
//-----------------------------------------------------------

TStudent::TStudent(
					int new_id_group, //ид группы
					int new_id_specialty,  //ид специальности
					string new_n_record_book, //номер зачетки
					int new_admission_year,   //год поступления
					int new_id_human, //ид человека
					int new_year,     //год рождения
					string new_name,  //имя
					string new_second_name,  //фамилия
					string new_address,  //адрес
					string new_passport, //паспорт
					string new_phone_number //номер телефона
					) : THuman(
								new_id_human, //ид человека
								new_year,     //год рождения
								new_name,  //имя
								new_second_name,  //фамилия
								new_address,  //адрес
								new_passport, //паспорт
								new_phone_number //номер телефона
								)  //конструктор базового класса
{
	id_group = new_id_group;
	id_specialty = new_id_specialty;
	n_record_book = new_n_record_book;
	admission_year = new_admission_year;
	next_student = NULL;
}
//-----------------------------------------------------------

void TStudent::set_id_group(int new_id_group)
{
	id_group = new_id_group;
}
//----------------------------------------------------------

void TStudent::set_id_specialty(int new_id_specialty)
{
	id_specialty = new_id_specialty;
}
//---------------------------------------------------------

void TStudent::set_n_record_book(string new_n_record_book)
{
	n_record_book = new_n_record_book;
}
//---------------------------------------------------------

void TStudent::set_admission_year(int new_admission_year)
{
	admission_year = new_admission_year;
}
//----------------------------------------------------------

void TStudent::set_next_student(TStudent* next)    //установить указатель на следующего студента в списке группы
{
	next_student = next;
}
//----------------------------------------------------------

int TStudent::get_id_group()
{
	return id_group;
}
//----------------------------------------------------------

int TStudent::get_id_specialty()
{
	return id_specialty;
}
//---------------------------------------------------------

string TStudent::get_n_record_book()
{
	return n_record_book;
}
//--------------------------------------------------------

int TStudent::get_admission_year()
{
	return admission_year;
}
//-------------------------------------------------------

TStudent* TStudent::get_next_student() //получить указатель на следующего студента в списке группы
{
	return next_student;
}