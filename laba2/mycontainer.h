#pragma once
#include <iostream>
#include<vector>
#include <initializer_list>

using namespace std;

template <class Contained_object>
class Mycontainer
{
private:
	vector<Contained_object> text;
	int rows;

public:
	Mycontainer()
	{
		text = nullptr;
		rows = 0;
	}

	Mycontainer(initializer_list<Contained_object> const& input) 
	{
		copy(input.begin(), input.end(), std::back_inserter(text));
		rows = text.size();
	}


	void addstring(Contained_object const& input) 
	{
		text.push_back(input);
	}

	void erase(typename vector<Contained_object>::iterator const& i) 
	{
		text.erase(i);
	}
	void erase(size_t index)
	{
		erase(begin() + index); 
	}

	void erase(typename vector<Contained_object>::iterator const& from,
		typename vector<Contained_object>::iterator const& to) 
	{
		text.erase(from, to);
	}
	void erase(size_t from, size_t to)
	{
		erase(begin() + from, begin() + to);
	}

	void clear()
	{
		text.clear(); 
	}

	int count() 
	{
		int len = 0;
		for (int i = 0; i < rows; i++)
		{
			len += text[i].mylength();
		}
		return len;
	}

	void replace(char was, char will)
	{
		for (int i = 0; i < rows; i++)
		{
			text[i].replace(was, will);
		}
	}

	auto choosestr(int index)
	{
		Contained_object choose(text[index - 1]);
		return choose;
	}

	int stringcounter()
	{
		return rows;
	}

	auto begin() { return text.begin(); }
	auto end() { return text.end(); }

	friend ostream& operator<<(ostream& show, Mycontainer<Contained_object> const& a) 
	{
		for (auto const& c : a.text) show << c << '\n';
		return show;
	}
};