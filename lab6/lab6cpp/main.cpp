#include <iostream>
#include "Expression.h"
#include <fstream>

using namespace std;


void Log(string* message)
{
	ofstream f;
	f.open("log.txt");
	if (f.is_open())
	{
		f << message;
	}
	f.close();
}

void Main()
{
	try
	{
		Expression* example1 = new Expression(8, 6, 3, 20);
		//Expression* example1 = new Expression(8, 6, 3, 25);

		/* example1 = example1 + 5;
		 example1 = example1 - 2;
		 example1 = example1 + new Expression (5,8,2);
		 */

		cout << example1->Calculate();
	}
	catch (const char* exception)
	{
		string* logText = new string(exception);
		Log(logText);
	}
	catch (domain_error exception)
	{
		string* logText = new string(exception.what());
		Log(logText);
	}
	catch (exception exception)
	{
		string* logText = new string(exception.what());
		Log(logText);
	}
	cout << "The end" << endl;

	char i;
	cin >> i;
}
