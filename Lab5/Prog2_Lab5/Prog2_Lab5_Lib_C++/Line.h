#pragma once
#include "vector"
#include "string"

using std::vector;
using std::string;

class Line
{
// protected залишає доступ похідним классам без повного відкриття данних
protected:
	vector<char> symbols;

public:
	Line(string input);

	virtual vector<char> GetWhole();

	virtual int Length();

	virtual int Count(char target);

	virtual int Count();
};

class Symbols : public Line
{
public:
	// Конструктори класу не наслідуються, але базовий конструктор викликається похідним класом
	Symbols(string input) : Line(input) { };

	int Count();

    // Базова функція Length задовільняє потреби підкласу і не переписується
};

class LargeLetters : public Line
{
public:
	// Конструктори класу не наслідуються, але базовий конструктор викликається похідним класом
	LargeLetters(string input) : Line(input) { };

	int Count();

	// Базова функція Length задовільняє потреби підкласу і не переписується
};