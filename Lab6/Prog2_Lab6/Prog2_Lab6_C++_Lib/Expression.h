#pragma once
#include <math.h>
#include <string>
#include <stdexcept>

class Expression
{
private:
    double a;
    double b;
    double c;
    double d;

    void Check();

public:
    double Calculate();

    Expression(double, double, double, double);

    void Change(char, double);
};

