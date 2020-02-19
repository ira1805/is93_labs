#include <iostream>
#include <string>

using namespace std;

int sum(int a, int b);
int increment(int x);
int decrement(int x);
bool comparing(int x, int y, string operation);


int main() {

	int a, b;
	string t;
	cout << "Your Operation: ";
	cin >> t;
	cout << "First Number: ";
	cin >> a;
	
	if ((t != "++") and (t != "--")) 
	{
	cout << "Second Number: ";
	cin >> b;
	}

	cout << "result: ";
	if (t == "+") cout << sum(a, b) << endl;
	if (t == "++") cout << increment(a) << endl;
	if (t == "--") cout << decrement(a) << endl;
	if (t == "<") cout << comparing(a, b, "<") << endl;
	if (t == ">") cout << comparing(a, b, ">") << endl;
	if (t == "==") cout << comparing(a, b, "==") << endl;



	return 0;
}

int sum(int x, int y) 
{
	while (y != 0)
	{
		int carry = x & y;
		x = x ^ y;
		y = carry << 1;
	}
	return x;
}

int increment(int x)
{
	x = -(~x);
	return x;
}

int decrement(int x)
{
	x = ~(-x);
	return x;

}

bool comparing(int x, int y, string operation) {
	int A, B;
	if (operation == "==") {
		for (int i = sizeof(int) * 8 - 1; i >= 0; i--) {
			A = (x >> i) & 1;
			B = (y >> i) & 1;
			if (A != B)
				return false;
		}return true;
	} 
	else if (operation == "<") {
		for (int i = sizeof(int) * 8 - 1; i >= 0; i--) {
			A = (x >> i) & 1;
			B = (y >> i) & 1;
			if (A < B)		// 0000011 0000000111
				return true;
			else if (B < A)
				return false;
		}return false;
	}
	else if (operation == ">") {
		for (int i = sizeof(int) * 8 - 1; i >= 0; i--) {
			A = (x >> i) & 1;
			B = (y >> i) & 1;
			if (A > B)
				return true;
			else if (A < B)
				return false;
		}return true;
	}
}