#include "THuman.h"


//конструктор
THuman::THuman()
{
	id_human = 0;
	year = 0;
	name = "";
	second_name = "";
	address = "";
	passport = "";
	phone_number = "";
}
//---------------------------------------------------

//конструктор
THuman::THuman(int new_id_human, int new_year, string new_name, string new_second_name, string new_address, string new_passport, string new_phone_number)
{
	id_human = new_id_human;
	year = new_year;
	name = new_name;
	second_name = new_second_name;
	address = new_address;
	passport = new_passport;
	phone_number = new_phone_number;
}
//---------------------------------------------------

void THuman::set_id_human(int new_id_human)
{
	id_human = new_id_human;
}
//-----------------------------------------------------

void THuman::set_year(int new_year)
{
	year = new_year;
}
//-----------------------------------------------------


void THuman::set_name(string new_name)
{
	name = new_name;
}
//-----------------------------------------------------

void THuman::set_second_name(string new_second_name)
{
	second_name = new_second_name;
}
//-----------------------------------------------------

void THuman::set_address(string new_address)
{
	address = new_address;
}
//-----------------------------------------------------

void THuman::set_passport(string new_passport)
{
	passport = new_passport;
}
//-----------------------------------------------------

void THuman::set_phone_number(string new_phone_number)
{
	phone_number = new_phone_number;
}
//------------------------------------------------------

int THuman::get_id_human() //возвращается значение
{
	return id_human;
}
//-------------------------------------------------------

int THuman::get_year()
{
	return year;
}
//------------------------------------------------------

string THuman::get_name()
{
	return name;
}
//--------------------------------------------------------

string THuman::get_second_name()
{
	return second_name;
}
//---------------------------------------------------------

string THuman::get_address()
{
	return address;
}
//--------------------------------------------------------

string THuman::get_passport()
{
	return passport;
}
//--------------------------------------------------------

string THuman::get_phone_number()
{
	return phone_number;
}
//------------------------------------------------------