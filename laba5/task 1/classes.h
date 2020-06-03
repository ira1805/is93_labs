#include <string>
#include <algorithm>
using namespace std;

class Strings  //���� �����
{	
protected:
	string str;  //�����

public:
	Strings(string inp) //����������� � �����������
	{
		str = inp;
	}

	int Length()  //����� ��������� ������� �����
	{
		return str.length();
	}
};

class SymbolStrings : public Strings   //���� ����������� �����, � ������� ������ �����
{
public:
	SymbolStrings(string inp) : Strings(inp) {}  //����������� ����������� ����� � ������� ������������ ���������� �����

	string Sort() //����� ���������� ����� �� ���������
	{
		sort(str.begin(), str.end());
		reverse(str.begin(), str.end());
		return this->str;
	}

	string GetStr() //����� ��������� �����
	{
		return "���������� �����: " + str;
	}
};