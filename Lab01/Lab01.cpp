#include "Header.h"

int main() {
	int num_1 = 0;
	int num_2 = 0;

	for (int i = 0; i < 3; i++) {
		cout << "Enter value number 1: ";
		cin >> num_1;
		cout << "Enter value number 2: ";
		cin >> num_2;

		int sum = getSum(num_1, num_2);
		cout << "Sum is: " << sum << endl << endl;
	}


	for (int i = 0; i < 3; i++) {
		int num_3 = 0;
		cout << "Enter value to be reducted: ";
		cin >> num_3;
		reduction(num_3);
		cout << "Reduction on 1: " << num_3 << endl << endl;

	}
	return 0;
}