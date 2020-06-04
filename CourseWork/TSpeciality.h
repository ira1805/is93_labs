#pragma once
//#include "TGroup.h"
//#include "TDiscipline.h"

using namespace std;

class TSpeciality
{
public:
	TSpeciality();
	TSpeciality(int new_id_speciality, int new_id_group, int new_id_discipline);

	void set_id_speciality(int new_id_speciality);
	void set_id_group(int new_id_group);
	void set_id_discipline(int new_id_discipline);

	int get_id_specialty();
	int get_id_group();
	int get_id_discipline();

private:
	int id_speciality;
	int id_group;
	int id_discipline;
};
//---------------------------------------------------------