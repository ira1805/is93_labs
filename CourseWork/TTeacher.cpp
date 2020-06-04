#include "TTeacher.h"

//�����������
TTeacher::TTeacher() : THuman() //����������� �������� ������
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
					int new_id_human, //�� ��������
					int new_year,     //��� ��������
					string new_name,  //���
					string new_second_name,  //�������
					string new_address,  //�����
					string new_passport, //�������
					string new_phone_number //����� ��������
					) 
					: THuman (
								new_id_human, //�� ��������
								new_year,     //��� ��������
								new_name,  //���
								new_second_name,  //�������
								new_address,  //�����
								new_passport, //�������
								new_phone_number //����� ��������
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