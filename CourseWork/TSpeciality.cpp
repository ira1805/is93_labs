#include "TSpeciality.h"

TSpeciality::TSpeciality()
{
	id_speciality = 0;
	id_group = 0;
	id_discipline = 0;
}
//---------------------------------------------------------

TSpeciality::TSpeciality(int new_id_speciality, int new_id_group, int new_id_discipline)
{
	id_speciality = new_id_speciality;
	id_group = new_id_group;
	id_discipline = new_id_discipline;
}
//---------------------------------------------------------

void TSpeciality::set_id_speciality(int new_id_specialty)
{
	id_speciality = new_id_specialty;
}
//--------------------------------------------

void TSpeciality::set_id_group(int new_id_group)
{
	id_group = new_id_group;
}
//---------------------------------------------------------

void TSpeciality::set_id_discipline(int new_id_discipline)
{
	id_discipline = new_id_discipline;
}
//---------------------------------------------------------

int TSpeciality::get_id_specialty()
{
	return id_speciality;
}



int TSpeciality::get_id_group()
{
	return id_group;
}
//---------------------------------------------------------

int TSpeciality::get_id_discipline()
{
	return id_discipline;
}
//---------------------------------------------------------
