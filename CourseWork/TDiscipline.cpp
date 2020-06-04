#include "TDiscipline.h"

TDiscipline::TDiscipline()
{
	id_discipline = 0;
	discipline_name = "";
}
//---------------------------------------------------------

TDiscipline::TDiscipline(int new_id_group,
	int new_id_teacher,
	string new_discipline_name,
	int new_id_discipline)
{
	id_discipline = new_id_discipline;
	id_teacher = new_id_teacher;
	id_group = new_id_group;
	discipline_name = new_discipline_name;	
}
//---------------------------------------------------------
void TDiscipline::set_id_discipline(int new_id_discipline)
{
	id_discipline = new_id_discipline;
}
//---------------------------------------------------------

void TDiscipline::set_id_teacher(int new_id_teacher)
{
	id_teacher = new_id_teacher;
}
//--------------------------------------------------------

void TDiscipline::set_id_group(int new_id_group)
{
	id_group = new_id_group;
}
//---------------------------------------------------------

void TDiscipline::set_discpline_name(string new_discipline_name)
{
	discipline_name = new_discipline_name;
}
//---------------------------------------------------------

int TDiscipline::get_id_discipline()
{
	return id_discipline;
}
//---------------------------------------------------------

int TDiscipline::get_id_teacher()
{
	return id_teacher;
}
//--------------------------------------------------------

int TDiscipline::get_id_group()
{
	return id_group;
}
//--------------------------------------------------------

string TDiscipline::get_discipline_name()
{
	return discipline_name;
}
//--------------------------------------------------------