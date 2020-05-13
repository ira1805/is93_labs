#include <iostream>
#include <vector>
#include "expression.h"
using namespace std;

void main() {
	cout << "Sokolnytska Ann IS-93\n\n\n"; 
	vector<expression> v(3);
	v[0] = expression();
	v[1] = expression();
	v[2] = expression(5, 7, 2);
	v[1].setVariables(5, 10, 11);
	cout << "первое выражение\n  a = 0\n  c = 0\n  b = 0\n  рассчет:  " << v[0].calculate() << "\n  result:  " << v[0].result()
		<< "\n\nвторое выражение\n  a = 5\n  c = 10\n  b = 11\n  рассчет:  " << v[1].calculate() << "\n  result:  " << v[1].result()
		<< "\n\nтретье выражение\n  a = -4\n  c = 7\n  b = 2\n  рассчет:  " << v[2].calculate() << "\n  result:  " << v[2].result()
		<< "\n\n";
	system("pause");
}