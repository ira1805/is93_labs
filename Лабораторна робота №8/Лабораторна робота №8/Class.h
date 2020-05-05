#pragma once
#include<string>
#include<iostream>
using namespace std;
class Class
{
private: string s;
public: Class(string s)
{
	this->s = s;
}
	  string GetStr()
	  {
		  return s;
	  }
	  void DelStr()
	  {
		  s = "\0";
	  }
	  bool FindLitteral()
	  {
		  for (int i = 0; i < s.length(); i++)
		  {
			  if (isalpha(s[i])==1)
			  {
				  return true;
				  break;
			  }
		  }
		  return false;
	  }
};

