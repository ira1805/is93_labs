#pragma once
#include"MyString.h"
#include<vector>
#include <stdio.h>
#include<iostream>
namespace Text
{
	class MyText : public MyString
	{
	public:
		int count = MyString::count;
	public: std::vector<MyString> arrgs;
	public:
		void AddStr_2(MyString textForAdd);
		void DeleteStr_2(int a);
		void DeleteText_2();
		void MinStr_2(std::vector<char>& a);
		void FirstChars_2(std::vector<char>& a);
		int CharCountInTextAndStr_2(char c);
	};
}