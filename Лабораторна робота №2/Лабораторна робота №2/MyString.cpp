#pragma once
#include"MyString.h"

int MyString::ÑharCount(MyString arr,char c)
{
	int k = 0;
		for (int j = 0; j <arr.count; j++)
		{
			if (arr.arrgs[j] == c)
			{
				k += 1;
			}
	}
	return k;
}
void MyString::GetStr(std::vector<char>arr)
{	
	arrgs = arr;
	count = arr.size();
}
int MyString::Size(MyString arr,int j)
{
	char c = ' ';
	int k = 0;
	for(int i=0;i<count;i++)
	{
		c = arr.arrgs[i];
		k++;
	}
	return k;
}
MyString::~MyString()
{
	arrgs.clear();
}
