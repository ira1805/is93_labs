#include <iostream>

using namespace std;

class Expression
{
private:
	int a, b, c, d;
public:
	Expression(int a, int b, int c, int d)
	{
		this->a = a;
		this->b = b;
		this->c = c;
		this->d = d;
	}
	double Calculation()
	{
		double log = 4 * b - c;
		double den = b + c / d - 1;
		if (den == 0)       //cheking denominator if it = 0
		{
			throw new DividingByNullException();
		}
		if (log <= 0)       //cheking if log expression less than zero
		{
			throw new NegativeExpressionExceptionInLg();
		}
		return (log10(log) * a / den);
	}
};

class DividingByNullException : exception
{
public:
	DividingByNullException() : exception("Expression can not be divided by null") {}
};

class NegativeExpressionExceptionInLg : exception
{
public:
	NegativeExpressionExceptionInLg() : exception("Expression in lg can not be negative") {}
};

int main()
{
	int a[3] = { 1, 6, 5 };
	int b[3] = { -2, 0, 3 };
	int c[3] = { 4, 1, 3 };
	int d[3] = { 9, 1, 3 };

	for (int i = 0; i < 3; i++)
	{
		Expression expression = Expression(a[i], b[i], c[i], d[i]);
		try
		{
			double result = expression.Calculation();
			cout << "Result = " << result << endl;
		}
		catch (exception e)
		{
			cout << e.what();
		}
	}
}