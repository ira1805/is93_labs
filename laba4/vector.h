#pragma once
#include <vector>
using namespace std;

class MyVector
{
private:
	double len;
	double ang;

public:
	MyVector()   //����������� �� ������������
	{			
		len = 0;
		ang = 0;
	}

	MyVector(double len, double ang)   //����������� � �����������
	{	
		this->len = len;
		this->ang = ang;
	}

	MyVector(MyVector& input)  //����������� ���������
	{	
		len = input.len;
		ang = input.ang;
	}

	void Povorot(double angle)   //����� �������� �� ������� ���
	{ 
		ang += angle;
	}

	double Len()   //����� ��������� �������
	{	
		return len;
	}

	double Ang()   //����� ��������� ����
	{	
		return ang;
	}

	MyVector operator=(MyVector z)   //�������������� ��������� ���������
	{	
		len = z.len;
		ang = z.ang;
		return *this;
	}

	MyVector operator*=(double x)   //�������������� ��������� ��������
	{	
		len = len * x;
		return *this;
	}

	MyVector operator+=(MyVector z)   //�������������� ��������� ���������
	{	
		len += z.len;
		ang += z.ang;
		return *this;
	}

	friend ostream& operator<<(ostream& stream, MyVector z)  //�������������� ��������� ���������
	{
		stream << "���i�� = " << z.len << "\n��� = " << z.ang << "�\n\n";
		return stream;
	}
};