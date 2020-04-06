#pragma once
#include<iostream>
#include<vector>
using namespace std;
class Strings
{
public:virtual int length(std::vector<char>s) { return 0; }//Virtual method for calculation the lenght of our string
      virtual std::vector<char> Change() { vector<char>a; return a; }//Virtual method for echange symbol to some symbols
};
class Symbols :public Strings//Class from String
{
private: std::vector<char> s;//Init arrgs
public: Symbols(std::vector<char>&s2)//Make designer with parametrs
    {
    for (int i = 0; i < s2.size(); i++)
    {
        s.push_back(s2[i]);
    }
}
      int length(std::vector<char> s)//Override method from class of String for calculation length of our string!!!
      {
          return s.size();
      }
      std::vector<char> Change()//Override method from class of String for exchenge one symbol to some symbols
      {
          std::vector<char> s3;
          int len = length(s);
          for (int i = 0; i < len * 2; i++)
          {
              if (i <= len - 1)
              {
                  s3.push_back(s[i]);
              }
              else
              {
                  s3.push_back('\0');
              }
          }
          for (int i = 0; i < length(s3); i++)
          {
              if (s3[i] == '#')
              {
                  int len3 = length(s3);
                  std::vector<char> s2;
                  for (int p = 0; p < len3; p++)
                  {
                      s2.push_back(s3[p]);
                  }
                  s3[i] = '!';
                  s3[i + 1] = '!';
                  for (int j = i + 2; j < s.size() + 2; j++)
                  {
                      s3[j] = s2[j - 1];
                  }
              }
              if (s3[i] == '\0')
              {
                  break;
              }
          }
          s.clear();
          for (int i = 0; i < s3.size(); i++)
          {
              if (s3[i] != '\0')
              {
                  s.push_back(s3[i]);
              }
              else
              {
                  break;
              }
          }
          return s;
      }
};
class Noumbers :public Strings
{
private:std::vector<char> s;//Init arrgs
public: 
    Noumbers(std::vector<char> s2)//Make designer with parametrs
    {
        for (int i = 0; i < s2.size(); i++)
        {
            s.push_back(s2[i]);
        }
    }
    int length(std::vector<char> s)//Override method from class of String for calculation length of our string!!!
    {
        return s.size();
    }
    std::vector<char> Change()//Override method from class of String for exchenge one symbol to some symbols
    {
        std::vector<char> s3;
        int len = length(s);
        for (int i = 0; i < len * 2; i++)
        {
            if (i <= len - 1)
            {
                s3.push_back(s[i]);
            }
            else
            {
                s3.push_back('\0');
            }
        }
        for (int i = 0; i < length(s3); i++)
        {
            if (s3[i] == '3')
            {
                int len3 = length(s3);
                std::vector<char> s2;
                for (int p = 0; p < len3; p++)
                {
                    s2.push_back(s3[p]);
                }
                s3[i] = '1';
                s3[i + 1] = '1';
                for (int j = i + 2; j < s.size() + 2; j++)
                {
                    s3[j] = s2[j - 1];
                }
            }
            if (s3[i] == '\0')
            {
                break;
            }
        }
        s.clear();
        for (int i = 0; i < s3.size(); i++)
        {
            if (s3[i] != '\0')
            {
                s.push_back(s3[i]);
            }
            else
            {
                break;
            }
        }
        return s;
    }
};

