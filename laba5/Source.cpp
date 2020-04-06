#include <iostream>
#include <string>
#include "classes.hpp"
using namespace std;

void main() {
	cout << "Baranov Dmytro IS-93\n\n";
	section s(0, 0, 3, 4);
	cout << "coordinates:\n" << s.getFirstCoordinates() << s.getSecondCoordinates()
		 << "length: " << s.length() << "\n\nthe angle with OY axis: " << s.angleOY() << "\n\n";
	system("pause");
}