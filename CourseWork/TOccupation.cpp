#include "TOccupation.h"

TOccupation::TOccupation() //конструктор
{
	id_teacher = 0;
	n_audience = 0;
	id_discipline = 0;
	id_occupation = 0;
	occupation_topic = " ";
}
//---------------------------------------------------------

TOccupation::TOccupation( int new_id_teacher,
	int new_n_audience,
	int new_id_discipline,
	string new_occupation_topic,
	int new_id_occupation)
{
	id_teacher = new_id_teacher;
	n_audience = new_n_audience;
	id_discipline = new_id_discipline;
	id_occupation = new_id_occupation;
	occupation_topic = new_occupation_topic;

}
//---------------------------------------------------------
void TOccupation::set_id_occupation(int new_id_occupation)
{
	id_occupation = new_id_occupation;
}
//---------------------------------------------------------

void TOccupation::set_occupation_topic(string new_occupation_topic)
{
	occupation_topic = new_occupation_topic;
}
//---------------------------------------------------------
int TOccupation::get_id_occupation()
{
	return id_occupation;
}
//---------------------------------------------------------
string TOccupation::get_occupation_topic()
{
	return occupation_topic;
}
//---------------------------------------------------------
