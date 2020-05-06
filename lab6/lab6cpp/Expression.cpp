#include "Expression.h"
#include <iostream>
#include <math.h>

using namespace std;

Expression::Expression(double a, double b,  double c, double d)
{
	this->a = a;
  this->b = b;
	this->c = c;
	this->d = d;
}

double Expression::Calculate()
{
	if ((a / b) <= 0)
	{
		throw domain_error("Logarithm from negative value not possible");
	}
	if ((c+b-d+a) == 0)
	{
		throw "Division by zero exception";
	}

	return (4 * log(10) * (a / b) + 1)/(c+b-d+a);
}

Expression* Expression::operator +(int num)
{
	return new Expression(this->a + num, this->b + num,  this->c + num, this->d + num);
}

Expression* Expression::operator +(Expression example)
{
	return new Expression(this->a + example.a, this->b + example.b,  this->c + example.c, this->d + example.d);
}

Expression* Expression::operator -(int num)
{
	return new Expression(this->a - num, this->b - num,  this->c - num, this->d - num);
}

Expression* Expression::operator -(Expression example)
{
	return new Expression(this->a - example.a, this->b - example.b,  this->c - example.c, this->d - example.d);
}
