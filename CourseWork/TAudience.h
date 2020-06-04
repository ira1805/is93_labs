#pragma once

//#include <iostream>
//#include "TTeacher.h"
#include <string>

using namespace std;

class TAudience
{
public:
	TAudience();
	TAudience(string new_n_audience,
		int new_id_teacher,
		string new_lecture_or_practice);

	void set_n_audience(string new_n_audience);
	void set_id_teacher(int new_id_teacher);
	void set_lecture_or_practice(string new_lectute_or_practice);

	string get_n_audience();
	int get_id_teacher();
	string get_lecture_or_practice();

private:
	string n_audience;
	int id_teacher;
	string lecture_or_practice;
};
//----------------------------------------------------------
