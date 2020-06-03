#include <cmath>
#include <string>
#include <stdexcept>
#include <iostream>
using namespace std;

class Viraz {
private:

	double a, b, c, result = 0;

public:

	Viraz()
	{
		a = b = c = 0;
	}

	Viraz(double a, double b, double c)
	{
		this->a = a;
		this->b = b;
		this->c = c;
	}

	void SetVars(double a, double b, double c)
	{
		this->a = a;
		this->b = b;
		this->c = c;
	}

	string Calculator()
	{
		try {
			if ((b / c == 42) || (c == 0))
				throw exception("\nпомилка дiлення на 0");
			else if (a * b <= -2)
				throw exception("\nпiдлогарифмiчний вираз може бути лише додатнiм");
			else
				throw 1;
		}
		catch (const exception& ex)
		{
			return ex.what();
		}
		catch (int)
		{
			result = (log(a * b + 2) * c) / (41 - b / c + 1);
			return "\nвиконано!";
		}
	}

	string Result()
	{
		if (result != NULL)
			return to_string(result);
		else
			return "помилка";
	}
};