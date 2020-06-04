
#include "TGroup.h"


TGroup::TGroup()    //�����������
{
	id_group = 0;
	group_name = "";
	n_students = 0;
	student_list = NULL;
}
//------------------------------------------------------------

TGroup::TGroup(int new_id_group, string new_group_name)    //�����������
{
	id_group = new_id_group;
	group_name = new_group_name;
	n_students = 0;
	student_list = NULL;
}
//----------------------------------------------------------

void TGroup::set_id_group(int new_id_group)            //���������� �� ������
{
	id_group = new_id_group;
}
//-----------------------------------------------------------

void TGroup::set_group_name(string new_group_name)    //���������� �������� ������
{
	group_name = new_group_name;
}
//-----------------------------------------------------------

void TGroup::add_student(TStudent* new_student)        //�������� �������� � ������
{
	//������� ����������� � ������ �������� ���� �������
	//����� ������ ������� ����������� � ����� ������

	if (student_list == NULL) //���� ������ ��������� ������
		student_list = new_student;   //�� ���������� ������ � ������
	else //���� ������ �� ������, �� �������� � ����� ������
		{
			TStudent* iterator = student_list; //������� ��������� �������� � ������������� � ������ ������
			while (iterator->get_next_student() != NULL)  //����� �� ����� ������
				iterator =	iterator->get_next_student();
			iterator->set_next_student(new_student);
		}

	n_students++; //��������� ���������� ��������� �� 1
}
//-------------------------------------------------------------

void TGroup::delete_student(string second_name)  //������� �������� �� ������ �� ��� �������
{
	if(student_list == NULL) return; //���� ������ ������, �� �����
	if (student_list->get_next_student() == NULL) //���� ���� ������� � ������
		if (student_list->get_second_name() == second_name) //���� ���, ��� �����, �� �������
		{// �������
			delete student_list; //������� ������������� ��������
			student_list = NULL; //�������� �� ���������
			return;              //�������
		}
		else return; //����� - �������

	//���� ��� � ����� ��������� � ������
	TStudent* iterator = student_list; //������� ��������� �������� � ������������� � ������ ������
	TStudent* pred_iterator = student_list; //�������� �� ���������� �������

	//����� �������� � ������
	while ((iterator != NULL) && (iterator->get_second_name() != second_name))
		{
			pred_iterator = iterator; //��������� �������� ��� ����������
			iterator = iterator->get_next_student(); //������� � ���������� ��������
		}
	
	if (iterator->get_second_name() != second_name) //���� ������� ������
		{//�� ������� ���
			pred_iterator->set_next_student(iterator->get_next_student());
			delete iterator;
			iterator = NULL;
		}
	else  //���� ������� �� ������
		cout << "������� " << second_name << " �� ������ � ������ ���� ������." << endl;
}
//------------------------------------------------------------

int TGroup::get_id_group()   //�������� �� ������
{
	return id_group;
}
//--------------------------------------------------------------

string TGroup::get_group_name()    //�������� �������� ������
{
	return group_name;
}
//------------------------------------------------------------

TStudent* TGroup::get_Student(int id) //�������� ������ �������� �� ��� ��
{
	TStudent* iterator = student_list; //������� ��������� �������� � ������������� � ������ ������
	while ((iterator != NULL) && (iterator->get_id_human() != id))
		iterator = iterator->get_next_student(); //������� � ���������� ��������

	if (iterator->get_id_human() != id) //���� ������� �������
		return iterator;
	else
		return NULL;
}
//--------------------------------------------------------------

int TGroup::get_n_students()  //�������� ���������� ��������� � ������
{
	return n_students;
}
//---------------------------------------------------------------