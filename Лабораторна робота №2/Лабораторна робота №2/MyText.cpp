#pragma once
#include "MyText.h"
#include "MyString.h"
#include <vector>
namespace Text
{
	void MyText::AddStr_2(MyString textForAdd)
	{
		arrgs.push_back(textForAdd);
	}
	void MyText::DeleteStr_2(int a)
	{
		arrgs.erase(arrgs.begin() + a - 1);
	}
	void MyText::DeleteText_2()
	{
		arrgs.clear();
	}
	void MyText::MinStr_2(std::vector<char>& a)
	{
		int min = arrgs[0].count;
		int i_m = 0;
		for (int i = 0; i < arrgs.size(); i++)
		{
			if (arrgs[i].count < min)
			{
				min = arrgs[i].count;
				i_m = i;
			}
		}
		for (int j = 0; j < arrgs[i_m].count; j++)
		{
			a.push_back(arrgs[i_m].arrgs[j]);
		}
	}
	void MyText::FirstChars_2(std::vector<char>& a)
	{
		for (int i = 0; i < arrgs.size(); i++)
		{
			a.push_back(arrgs[i].arrgs[0]);
		}
	}
	int MyText::CharCountInTextAndStr_2(char c)
	{
		int s = 0;
		for (int i = 0; i < arrgs.size(); i++)
		{
			int Counte = arrgs[i].ÑharCount(arrgs[i], c);
			s += Counte;
		}
		return s;
	}
}