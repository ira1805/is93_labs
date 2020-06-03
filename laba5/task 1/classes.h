#include <string>
#include <algorithm>
using namespace std;

class Strings  //клас рядка
{	
protected:
	string str;  //рядок

public:
	Strings(string inp) //конструктор з параметрами
	{
		str = inp;
	}

	int Length()  //метод отримання довжини рядка
	{
		return str.length();
	}
};

class SymbolStrings : public Strings   //клас символьного рядка, є дочірнім класом рядка
{
public:
	SymbolStrings(string inp) : Strings(inp) {}  //конструктор символьного рядка з визовом конструктору звичайного рядка

	string Sort() //метод сортування рядка за спаданням
	{
		sort(str.begin(), str.end());
		reverse(str.begin(), str.end());
		return this->str;
	}

	string GetStr() //метод отримання рядка
	{
		return "символьний рядок: " + str;
	}
};