#pragma once
#include<math.h>
#include<iostream>
#include <windows.h>

using namespace std;
class ExpressionClassC
{
private: double a, b, c, d;//Our values
public: ExpressionClassC(double a, double b, double c, double d)//Constructor with parametrs
    {
        this->a = a;
        this->b = b;
        this->c = c;
        this->d = d;
    }
public: double Value()//Method for output of value our Expression
{
    try
    {
        if (d > 41)//If d>41 i show massage
        {
            throw "Expression have a zero the root!";//Output message with exception
        }
    }
    catch (const char* s)
    {
        MessageBoxA(GetActiveWindow(), s, "Error. Value = NULL!", MB_ICONERROR);//Output message box with info
        exit(1);//Close the window and exit from programm
    }
    try
    {
            if (sqrt(41 - d) - b * a + c == 0)//If denominator = 0 i show massage with exception
            {
                throw "Expression have a zero the denominator!";//I show message with exception
            }
    }
    catch (const char * a)
    {
        MessageBoxA(GetActiveWindow(), a, "Error message", MB_ICONERROR);//Output message box with info
        exit(1);//Close the window and exit from programm
    }
    return(((a * b / 4.0) - 1) / (sqrt(41 - d) - b * a + c));//Else, i return value of expression
}
};