#include "TSchedule.h"

TSchedule::TSchedule()
{
	id_group = 0;
	id_discipline = 0;
	id_occupation = 0;
	id_teacher = 0;
	date = 0;
	day_of_the_week = "";
	lesson_number = 0;
}
//---------------------------------------------------------

TSchedule::TSchedule(
	int new_id_group,
	int new_id_discipline,
	int new_id_occupation,
	int new_id_teacher,
	int new_date,
	string new_day_of_the_week,
	int new_lesson_number)
{
	id_group = new_id_group;
	id_discipline = new_id_discipline;
	id_occupation = new_id_occupation;
	id_teacher = new_id_teacher;
	date = new_date;
	day_of_the_week = new_day_of_the_week;
	lesson_number = new_lesson_number;
}
//---------------------------------------------------------

void TSchedule::set_id_group(int new_id_group)
{
	id_group = new_id_group;
}
//---------------------------------------------------------

void TSchedule::set_id_discipline(int new_id_discipline)
{
	id_discipline = new_id_discipline;
}
//---------------------------------------------------------

void TSchedule::set_id_occupation(int new_id_occupation)
{
	id_occupation = new_id_occupation;
}
//---------------------------------------------------------

void TSchedule::set_id_teacher(int new_id_teacher)
{
	id_teacher = new_id_teacher;
}
//---------------------------------------------------------

void TSchedule::set_date(int new_date)
{
	date = new_date;
}
//---------------------------------------------------------

void TSchedule::set_day_of_the_week(string new_day_of_the_week)
{
	day_of_the_week = new_day_of_the_week;
}
//---------------------------------------------------------

void TSchedule::set_lesson_number(int new_lesson_number)
{
	lesson_number = new_lesson_number;
}
//---------------------------------------------------------

int TSchedule::get_id_group()
{
	return id_group;
}
//---------------------------------------------------------

int TSchedule::get_id_discipline()
{
	return id_discipline;
}
//---------------------------------------------------------

int TSchedule::get_id_occupation()
{
	return id_occupation;
}
//---------------------------------------------------------

int TSchedule::get_id_teacher()
{
	return id_teacher;
}
//---------------------------------------------------------

int TSchedule::get_date()
{
	return date;
}
//---------------------------------------------------------

string TSchedule::get_day_of_the_week()
{
	return day_of_the_week;
}
//---------------------------------------------------------

int TSchedule::get_lesson_number()
{
	return lesson_number;
}
//---------------------------------------------------------