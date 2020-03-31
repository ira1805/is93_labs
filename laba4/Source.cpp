#include <iostream>
#include "vector.hpp"
using namespace std;

void main() {
	cout << "Baranov Dmytro IS-93\n\n\n";
	vectorPol v1;
	vectorPol v2(5, 30);
	vectorPol v3(v2);
	cout << "v1()\n" << v1 << "\nv2(5, 30)\n" << v2 << "\nv3(v2)\n" << v3;
	v2 /= 2;
	v3.rotate(45);
	cout << "\nv2 / 2\n" << v2 << "\nrotate v3 on 45deg\n" << v3;
	v2 += v3;
	v1 = v2;
	cout << "\nv2 + v3\n" << v2 << "\nv1: result\nradius: " << v1.getRad() << "\n angle: " << v1.getAng() << "\n\n";
	system("pause");
}