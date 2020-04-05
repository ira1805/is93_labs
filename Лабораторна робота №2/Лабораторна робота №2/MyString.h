#pragma once
#include<vector>
class MyString
{
public:  std::vector<char> arrgs;
	  int count=0;
public:
	void GetStr(std::vector<char>arr);
	int ÑharCount(MyString arr, char c);
	int Size(MyString arr,int j);
	~MyString();
};