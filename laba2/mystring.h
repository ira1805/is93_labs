#pragma once
#include <iostream>

using namespace std;

class Mystring
{
private:
	char* str;
	int len;

public:

	Mystring()
	{
		str = nullptr;
		len = 0;
	}

	Mystring(const char* str)
	{

		len = strlen(str);
		this->str = new char[len + 1];

		for (int i = 0; i < len; i++)
		{
			this->str[i] = str[i];
		}

		this->str[len] = '\0';

	}
	~Mystring()
	{
		delete[] this->str;
	}

	Mystring(const Mystring& other)
	{
		len = strlen(other.str);
		this->str = new char[len + 1];

		for (int i = 0; i < len; i++)
		{
			this->str[i] = other.str[i];
		}

		this->str[len] = '\0';
	}

	Mystring(Mystring&& other)
	{
		this->len = other.len;
		this->str = other.str;
		other.str = nullptr;
	}

	Mystring& operator=(const Mystring& other)
	{
		if (this->str != nullptr)
		{
			delete[] str;
		}

		len = strlen(other.str);
		this->str = new char[len + 1];

		for (int i = 0; i < len; i++)
		{
			this->str[i] = other.str[i];
		}

		this->str[len] = '\0';

		return *this;
	}

	Mystring operator+(const Mystring& other)
	{
		Mystring newStr;

		int thisLength = strlen(this->str);
		int otherLength = strlen(other.str);

		newStr.len = thisLength + otherLength;
		newStr.str = new char[thisLength + otherLength + 1];

		int i = 0;
		for (; i < thisLength; i++)
		{
			newStr.str[i] = this->str[i];
		}

		for (int j = 0; j < otherLength; j++, i++)
		{
			newStr.str[i] = other.str[j];
		}

		newStr.str[thisLength + otherLength] = '\0';

		return newStr;
	}

	bool operator == (const Mystring& other)
	{
		if (this->len != other.len)
		{
			return false;
		}

		for (int i = 0; i < this->len; i++)
		{
			if (this->str[i] != other.str[i])
			{
				return false;
			}
		}
		return true;
	}

	bool operator !=(const Mystring& other)
	{
		return !(this->operator==(other));
	}

	char& operator [](int index)
	{
		return this->str[index];
	}

	int mylength()
	{
		return len;
	}

	Mystring replace(char was, char will)
	{
		Mystring newStr;
		for (int i = 0; i < strlen(str); i++)
		{
			if (was == str[i])
			{
				str[i] = will;
			}
		}
		return newStr;
	}

	friend ostream& operator<<(ostream& os, const Mystring& output);
	friend istream& operator>>(istream& is, Mystring& input);
};

ostream& operator<<(ostream &os, const Mystring& output)
{
	return os << output.str;
}

istream& operator>>(istream& is, Mystring& input)
{
	char* strr = new char[100];
	is >> strr;
	input.len = strlen(strr);
	input.str = new char[input.len + 1];
	for (int i = 0; i < input.len; i++)
	{
		input.str[i] = strr[i];
	}

	input.str[input.len] = '\0';
	delete[] strr;

	return is;
}