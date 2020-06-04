#include "TTeacher.h"

//конструктор
TTeacher::TTeacher() : THuman() //конструктор базового класса
{
	id_teacher = 0;
	id_discipline = 0;
	the_audience = 0;
	department = "";
	academic_rank = "";
}
//------------------------------------------------
TTeacher::TTeacher(
					int new_id_teacher,
					int new_id_discipline,
					int new_audience,
					string new_department,
					string new_academic_rank,
					int new_id_human, //ид человека
					int new_year,     //год рождения
					string new_name,  //имя
					string new_second_name,  //фамилия
					string new_address,  //адрес
					string new_passport, //паспорт
					string new_phone_number //номер телефона
					) 
					: THuman (
								new_id_human, //ид человека
								new_year,     //год рождения
								new_name,  //имя
								new_second_name,  //фамилия
								new_address,  //адрес
								new_passport, //паспорт
								new_phone_number //номер телефона
							   )
{
	id_teacher = new_id_teacher;
	id_discipline = new_id_discipline;
	the_audience = new_audience;
	department = new_department;
	academic_rank = new_academic_rank;
}
//-----------------------------------------------------

void TTeacher::set_id_teacher(int new_id_teacher)
{
	id_teacher = new_id_teacher;
}
//------------------------------------------------------

void TTeacher::set_id_discipline(int new_id_discipline)
{
	id_discipline = new_id_discipline;
}
//------------------------------------------------------

void TTeacher::set_the_audience(int new_the_audience)
{
	the_audience = new_the_audience;
}
//------------------------------------------------------

void TTeacher::set_department(string new_department)
{
	department = new_department;
}
//------------------------------------------------------

void TTeacher::set_academic_rank(string new_academic_rank)
{
	academic_rank = new_academic_rank;
}
//------------------------------------------------------

int TTeacher::get_id_teacher()
{
	return id_teacher;
}
//-----------------------------------------------------

int TTeacher::get_id_discipline()
{
	return id_discipline;
}
//--------------------------------------------------

int TTeacher::get_the_audience()
{
	return the_audience;
}
//-----------------------------------------------------

string TTeacher::get_departmemt()
{
	return department;
}
//----------------------------------------------------

string TTeacher::get_academic_rank()
{
	return academic_rank;
}
//----------------------------------------------------