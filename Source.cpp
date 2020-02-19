#include <iostream>

using namespace std;

void increase(int* x) {
	int bit = 1, counter = 0;
	while (bit != 0) {
		bit = (*x >> counter) & 1;
		*x ^= 1 << counter;
		counter++;
	}
}

bool compare(int a, int b) {
	int bitA = (a >> 15) & 1, bitB = (b >> 15) & 1;
	if (bitA == 0 && bitB == 1)
		return 1;
	else if (bitA == 1 && bitB == 0)
		return 0;
	else
		for (int i = 14; i >= 0; i--) {
			bitA = (a >> i) & 1;
			bitB = (b >> i) & 1;
			cout << bitA << " " << bitB << endl;
			if (bitA != bitB && bitA == 1)
				return 1;
			else if (bitA != bitB)
				return 0;
		}
	return 0;
}

void main() {
	cout << "Baranov Dmytro, IS-93" << endl;
	int a = 25, b = -9, c = 5;
	increase(&a);
	cout << a << endl << endl;
	bool res = compare(b, c);
	cout << res << endl;
	system("pause");
}