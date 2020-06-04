#include "TAudience.h"

//конструктор
TAudience::TAudience()  //конструктор базового класса
{
	n_audience = "";
	id_teacher = 0;
	lecture_or_practice = "";
}
//---------------------------------------------------------

TAudience::TAudience(string new_n_audience,
	int new_id_teacher,
	string new_lecture_or_practice)
{
	n_audience = new_n_audience;
	id_teacher = new_id_teacher;
	lecture_or_practice = new_lecture_or_practice;
}
//---------------------------------------------------------
void TAudience::set_n_audience(string new_n_audience)
{
	n_audience = new_n_audience;
}
//---------------------------------------------------------

void TAudience::set_id_teacher(int new_id_teacher)
{
	id_teacher = new_id_teacher;
}
//---------------------------------------------------------

void TAudience::set_lecture_or_practice(string new_lectute_or_practice)
{
	lecture_or_practice = new_lectute_or_practice;
}
//---------------------------------------------------------

string TAudience::get_n_audience()
{
		return n_audience;
}
//---------------------------------------------------------

int TAudience::get_id_teacher()
{
		return id_teacher;
}
//---------------------------------------------------------

string TAudience::get_lecture_or_practice()
{
		return lecture_or_practice;
}
//---------------------------------------------------------
