#include "Header.h"

void reduction(int& num) {
	int num_bit = 0;
	int i = 0;
	while (num_bit != 1) {
		num_bit = (num >> i) & 1;
		num = num ^ (1 << i);
		i++;
	}
}

int getSum(int num1, int num2)
{
	int move = 0, sum = 0;
	for (int i = 0; i < sizeof(int) * 8; i++)
	{
		int num1_bit = (num1 >> i) & 1;
		int num2_bit = (num2 >> i) & 1;

		int sum_bits = num1_bit ^ num2_bit ^ move;
		move = move == 0 ? (num1_bit & num2_bit) : (num1_bit | num2_bit);
		sum = sum | (sum_bits << i);
	}
	return sum;
}