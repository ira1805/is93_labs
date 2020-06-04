
#include "TGroup.h"


TGroup::TGroup()    //конструктор
{
	id_group = 0;
	group_name = "";
	n_students = 0;
	student_list = NULL;
}
//------------------------------------------------------------

TGroup::TGroup(int new_id_group, string new_group_name)    //конструктор
{
	id_group = new_id_group;
	group_name = new_group_name;
	n_students = 0;
	student_list = NULL;
}
//----------------------------------------------------------

void TGroup::set_id_group(int new_id_group)            //установить ид группы
{
	id_group = new_id_group;
}
//-----------------------------------------------------------

void TGroup::set_group_name(string new_group_name)    //установить название группы
{
	group_name = new_group_name;
}
//-----------------------------------------------------------

void TGroup::add_student(TStudent* new_student)        //добавить студента в группу
{
	//студент добавляется в список объектов типа студент
	//новый объект студент добавляется в конец списка

	if (student_list == NULL) //если список студентов пустой
		student_list = new_student;   //то установить первым в списке
	else //если список не пустой, то добавить в конце списка
		{
			TStudent* iterator = student_list; //создаем временный итератор и устанавливаем в начало списка
			while (iterator->get_next_student() != NULL)  //дойти до конца списка
				iterator =	iterator->get_next_student();
			iterator->set_next_student(new_student);
		}

	n_students++; //увеличить количество студентов на 1
}
//-------------------------------------------------------------

void TGroup::delete_student(string second_name)  //удалить студента из группы по его фамилии
{
	if(student_list == NULL) return; //если список пустой, то выйти
	if (student_list->get_next_student() == NULL) //если один студент в списке
		if (student_list->get_second_name() == second_name) //если тот, кто нужен, то удаляем
		{// удалаем
			delete student_list; //удалаем единственного студента
			student_list = NULL; //заглушку на указатель
			return;              //выходим
		}
		else return; //иначе - выходим

	//если два и более студентов в списке
	TStudent* iterator = student_list; //создаем временный итератор и устанавливаем в начало списка
	TStudent* pred_iterator = student_list; //итератор на предыдущий элемент

	//найти студента в списке
	while ((iterator != NULL) && (iterator->get_second_name() != second_name))
		{
			pred_iterator = iterator; //сохранить итератор как предыдущий
			iterator = iterator->get_next_student(); //перейти к следующему студенту
		}
	
	if (iterator->get_second_name() != second_name) //если студент найден
		{//то удалить его
			pred_iterator->set_next_student(iterator->get_next_student());
			delete iterator;
			iterator = NULL;
		}
	else  //если студент не найден
		cout << "Студент " << second_name << " не найден в списке этой группы." << endl;
}
//------------------------------------------------------------

int TGroup::get_id_group()   //получить ид группы
{
	return id_group;
}
//--------------------------------------------------------------

string TGroup::get_group_name()    //получить название группы
{
	return group_name;
}
//------------------------------------------------------------

TStudent* TGroup::get_Student(int id) //получить объект студента по его ид
{
	TStudent* iterator = student_list; //создаем временный итератор и устанавливаем в начало списка
	while ((iterator != NULL) && (iterator->get_id_human() != id))
		iterator = iterator->get_next_student(); //перейти к следующему студенту

	if (iterator->get_id_human() != id) //если студент нашелся
		return iterator;
	else
		return NULL;
}
//--------------------------------------------------------------

int TGroup::get_n_students()  //получить количество студентов в группе
{
	return n_students;
}
//---------------------------------------------------------------