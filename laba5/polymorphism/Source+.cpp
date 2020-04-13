#include <iostream>
#include <string>
#include "classes+.hpp"
using namespace std;

void main() {
	cout << "Baranov Dmytro IS-93\n\n\n";
	uppercas up("UPPERCASE");
	lowercase low("lowercase");
	cout << "class uppercase:\n\n data:  'UPPERCASE'\n\n lenght:  " << up.length() << "\n\n sort:  ";
	up.sort();
	cout << "\n\n\nclass lowercase:\n\n data:  'lowercase'\n\n length:  " << low.length() << "\n\n sort:  ";
	low.sort();
	cout << "\n\n\n";
	system("pause");
}