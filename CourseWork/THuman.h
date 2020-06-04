#pragma once
#include <string>

using namespace std;

class THuman
{
public:
	void set_id_human(int new_id_human);
	void set_year(int new_year);
	void set_name(string new_name);
	void set_second_name(string new_second_name);
	void set_address(string new_address);
	void set_passport(string new_passport);
	void set_phone_number(string new_fone_number);

	int get_id_human(); //������������ �������� id ��������
	int get_year();
	string get_name();
	string get_second_name();
	string get_address();
	string get_passport();
	string get_phone_number();

	//������������
	THuman(); 
	THuman(int new_id_human, int new_year, string new_name, string new_second_name, string new_address, string new_passport, string new_fone_number);

private:
	int id_human; //�� ��������
	int year;     //��� ��������
	string name;  //���
	string second_name;  //�������
	string address;  //�����
	string passport; //�������
	string phone_number; //����� ��������
};
//------------------------------------------------------------------------------------