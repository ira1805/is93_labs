
#include "TStudent.h"

//�����������
TStudent::TStudent() : THuman() //����������� �������� ������
{
	id_group = 0;
	id_specialty = 0;
	n_record_book = "";
	admission_year = 0;
	next_student = NULL;
}
//-----------------------------------------------------------

TStudent::TStudent(
					int new_id_group, //�� ������
					int new_id_specialty,  //�� �������������
					string new_n_record_book, //����� �������
					int new_admission_year,   //��� �����������
					int new_id_human, //�� ��������
					int new_year,     //��� ��������
					string new_name,  //���
					string new_second_name,  //�������
					string new_address,  //�����
					string new_passport, //�������
					string new_phone_number //����� ��������
					) : THuman(
								new_id_human, //�� ��������
								new_year,     //��� ��������
								new_name,  //���
								new_second_name,  //�������
								new_address,  //�����
								new_passport, //�������
								new_phone_number //����� ��������
								)  //����������� �������� ������
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

void TStudent::set_next_student(TStudent* next)    //���������� ��������� �� ���������� �������� � ������ ������
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

TStudent* TStudent::get_next_student() //�������� ��������� �� ���������� �������� � ������ ������
{
	return next_student;
}