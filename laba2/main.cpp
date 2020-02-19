#include <iostream>
using namespace std;

void summation_numbers(int num1, int num2, int* summary){
    int bit1, bit2;
    int previous = 0; // If bit1 and bit2 are equal to 1, then we skip those bits and move to next
    for (int index = 0; index < sizeof(int) * 8 - 1; index = -~index)
    {
        bit1 = num1 & (1 << index);  // bit1 and bit2 are equal to 0 or some number
        bit2 = num2 & (1 << index);
        if (bit1 != 0) { bit1 = 1; }
        if (bit2 != 0) { bit2 = 1; }
        if ((bit1 != bit2 && previous == 0) || (bit1 == bit2 && bit1 == 0 && previous == 1))
        {
            *summary |= (1 << index);
            previous = 0;
        }
        else
        {
            if (((bit1 == bit2) && bit1 == 1 && previous == 0) || (bit1 != bit2 && previous == 1))
            {
                previous = 1;
            } else if (bit1 == bit2 && bit1 == 1 && previous == 1)
            {
                *summary |= (1 << index);
            }
        }
    }
}

bool comparising(int num1, int num2){
    bool flag = false;

    for (int index = sizeof(int) * 8; index > 0; index = ~-index)
    {
        int bit1 = num1 & (num1 << index);
        int bit2 = num2 & (num2 << index);
        if (bit1 != 0) { bit1 = 1; }  // Because bit1 and bit2 are equal to 0 or some number
        if (bit2 != 0) { bit2 = 1; }
        if (bit1 == bit2)  // Compare 2 bits of 2 numbers
        {
            flag = true;
        } else
        {
            return false;
        }
    }

    return flag;
}


int main() {
    int number1, number2;
    bool resultOfComparising;
    int resultOfSum = 0;
    string result;

    cout << "Enter first number: ";  // Enter data
    cin >> number1;
    cout << "Enter second number: ";
    cin >> number2;

    resultOfComparising = comparising(number1, number2);
    summation_numbers(number1, number2, &resultOfSum);
    if (resultOfComparising == 1) { result = "true"; }
    if (resultOfComparising == 0) { result = "false"; }
    cout << "The result of comparising number 1 and number 2 is " << result << endl;
    cout << "Result of addition is " << resultOfSum << endl;

}
