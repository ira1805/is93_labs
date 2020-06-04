#pragma once

#include <iostream>
#include <fstream>
#include <stdio.h>

using namespace std;

class TInputOutput
{
public:
	void show_file(string fname);
	void add_new(string fname, string new_string);
	string make_new(string header, string mask); //������� ����� ��������
	void edit(string fname, string id, string new_line);//�������������
	void dispatcher(int menu_id);

private:
	ifstream inp_f;
	ofstream out_f;
};