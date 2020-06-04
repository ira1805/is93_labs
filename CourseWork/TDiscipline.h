#pragma once
#include <iostream>
#include <string>

//#include "TGroup.h"
//#include "TSpeciality.h"
//#include "TTeacher.h"

using namespace std;

class TDiscipline
{
public:
	TDiscipline();
	TDiscipline(int new_id_group,
		int new_id_teacher,
		string new_discipline_name,
		int new_id_discipline);

	void set_id_discipline(int new_id_discipline);
	void set_discpline_name(string new_discipline_name);
	void set_id_teacher(int new_id_teacher);
	void set_id_group(int new_id_group);
	int get_id_discipline();
	int get_id_teacher();
	int get_id_group();
	string get_discipline_name();

private:
	int id_discipline;
	int id_teacher;
	int id_group;
	string discipline_name;
};
//---------------------------------------------------------