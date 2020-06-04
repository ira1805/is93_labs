#pragma once
#include <string>
#include <iostream>
//#include "TTeacher.h"
//#include "TGroup.h"
//#include "TAudience.h"
//#include "TDiscipline.h"
//#include "TOccupation.h"

using namespace std;

class TSchedule
{
public:
	TSchedule();
	TSchedule(int new_id_group,
		int new_id_discipline,
		int new_id_occupation,
		int new_id_teacher,
		int new_date,
		string new_day_of_the_week,
		int new_lesson_number);

	void set_id_group(int new_id_group);
	void set_id_discipline(int new_id_discipline);
	void set_id_occupation(int new_id_occupation);
	void set_id_teacher(int new_id_teacher);
	void set_date(int new_date);
	void set_day_of_the_week(string new_day_of_the_week);
	void set_lesson_number(int new_lesson_number);

	int get_id_group();
	int get_id_discipline();
	int get_id_occupation();
	int get_id_teacher();
	int get_date();
	string get_day_of_the_week();
	int get_lesson_number();

private:
	int id_group;
	int id_discipline;
	int id_occupation;
	int id_teacher;
	int date;
	string day_of_the_week;
	int lesson_number;
};
//---------------------------------------------------------