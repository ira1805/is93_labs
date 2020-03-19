#include <iostream>
#include <vector>


using namespace std;


class MyString
{
private:
	const vector <char> ConstonantLetters = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v', 'x', 'z' };
	vector <char> _value;
public:

	MyString(vector<char> str)
	{
		_value = str;
	}
	int GetLength()
	{
		int n = _value.size();
		return n;
	}
	int GetCountOfConsonantLetters()
	{
		int n = GetLength();
		int count = 0;
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				if (_value[i] == ConstonantLetters[j])
				{
					count += 1;
					break;
				}
			}
		}
		return count;
	}
	void DeleteWhiteSpaces()
	{
		if (_value[0] == ' ')
		{
			vector<char> temp;
			for (int i = 0; i < GetLength(); i++)
			{
				temp[i] = _value[i + 1];
			}
			_value = temp;
		}
		if (_value[GetLength() - 1] == ' ')
		{
			vector<char> temp;
			for (int i = 0; i < GetLength() - 1; i++)
			{
				temp[i] = _value[i];
			}
			_value = temp;
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

class MyText
{
private:

	vector<MyString> _stringsArray;

public:

	MyText(vector<MyString> stringsArray)
	{
		_stringsArray = stringsArray;
	}

	void AddingString(MyString str)
	{
		_stringsArray.push_back(str);
	}
	void DeleteString(int index)
	{
		vector<MyString> NewText;
		for (int i = 0; i < index - 1; i++)
		{
			NewText.push_back(_stringsArray[i]);
		}
		for (int i = index; i < _stringsArray.size(); i++)
		{
			NewText.push_back(_stringsArray[i]);
		}
		_stringsArray = NewText;
	}
	void CleaneArrray()
	{
		vector<MyString> EmptyText;
		_stringsArray = EmptyText;
	}
	int GetShortestStringLength()
	{
		int minLegth = INT16_MAX;
		for (int i = 0; i < _stringsArray.size(); i++)
		{
			MyString temp = _stringsArray[i];
			int length = temp.GetLength();
			if (length < minLegth)
			{
				minLegth = length;
			}
		}
		return minLegth;
	}
	double GetConsonantLettersPercentage()
	{
		int sumStringsLegth = 0;
		int sumConsonantLetters = 0;
		for (int i = 0; i < _stringsArray.size(); i++)
		{
			sumStringsLegth += _stringsArray[i].GetLength();
			sumConsonantLetters += _stringsArray[i].GetCountOfConsonantLetters();
		}
		return ((double)sumConsonantLetters / sumStringsLegth) * 100;
	}
	void DeleteWhiteSpaces()
	{
		for (int i = 0; i < _stringsArray.size(); i++)
		{
			_stringsArray[i].DeleteWhiteSpaces();
		}
	}
	void Print()
	{
		for (int i = 0; i < _stringsArray.size(); i++)
		{
			_stringsArray[i].Print();
		}
		cout << endl;
	}
};

int main()
{
	MyString string1 = MyString(vector<char> { 's', 't', 'r', ' ' });
	MyString string2 = MyString(vector<char> { 's', 't', 'r', '1', '2' });
	MyString string3 = MyString(vector<char> { 's', 't', 'r', '1', '2', '3' });

	MyText text = MyText(vector<MyString> {string1, string2, string3});

	cout << "Array before changes: " << endl;
	text.Print();
	cout << "Array after adding 1 string: " << endl;
	text.AddingString(string2);
	text.Print();
	int length = text.GetShortestStringLength();
	cout << "Shortest string length: " << length << endl;
	double percant = text.GetConsonantLettersPercentage();
	cout << "Percant of constonant letters: " << percant << "%" << endl;
	text.DeleteWhiteSpaces();
	cout << "Array afetr deleted whitespaces" << endl;
	text.Print();
	cout << "Enter number of string which must delete" << endl;
	int index;
	cin >> index;
	text.DeleteString(index);
	cout << "Array after delete string: ";
	text.Print();
	text.CleaneArrray();
}