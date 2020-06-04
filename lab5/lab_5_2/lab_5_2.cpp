#include <iostream>
#include <vector>
#include<string>

using namespace std;

class String
{
public:
	string _value;
	
	String(string str)
	{
		_value = str;
	}

	virtual int GetLength() = 0;

	virtual void AddItem() = 0;
};

class Digits : String
{
public:

	Digits(string str) : String(str)
	{
		_value = str;
	}

	int GetLength()
	{
		return _value.length();
	}
	void AddItem()
	{
		int n = GetLength();
		for (int i = 0; i < 2 * n; i++)
		{
			string c = "";
			c.append(1, _value[i]);
			_value = _value.insert(i + 1, c);
			i++;
		}
	}

	void Print()
	{
		for (int i = 0; i < GetLength(); i++)
		{
			cout << _value[i];
		}
		cout << endl;
	}

};

class Character : String
{
public:
	Character(string str) : String(str)
	{
		_value = str;
	}
	int GetLength()
	{
		return _value.size();
	}

	void AddItem()
	{
		int n = GetLength();
		int count = 0;
		for (int i = 0; i < n; i++)
		{
			if (_value[i] == 'k')
			{
				count++;
			}
		}
		for (int i = 0; i < n + count; i++)
		{
			if (_value[i] == 'k')
			{
				string c = "";
				c.append(1, _value[i]);
				_value = _value.insert(i + 1, c);
				i++;
			}
		}
	}

	void Print()
	{
		for (int i = 0; i < GetLength(); i++)
		{
			cout << _value[i];
		}
		cout << endl;
	}
};


int main()
{
	Digits strdigit = Digits(string{"145"});
	Character strcharacters = Character(string{ "abkck" });

	cout << " String of digit before adding characters: " ;
	strdigit.Print();
	cout << " String of digit after adding characters: ";
	strdigit.Print();
	cout << "String length" << strdigit.GetLength() << endl;

	cout << " String of characters before adding characters: ";
	strcharacters.Print();
	cout << " String of characters after adding characters: ";
	strcharacters.Print();
	cout << "String length" << strdigit.GetLength() << endl;
}