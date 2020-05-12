#include <iostream>
#include <vector>
using namespace std;

vector<int> sort(vector<int> arr) { //sort function
    int i, j;
    for (i = 0; i < arr.size() - 1; i++)
        for (j = 0; j < arr.size() - i - 1; j++)
            if (arr[j] > arr[j + 1]) {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
    return arr;
}

void main() {
	vector<int> arr = {6, 1, 7, 9, 2, 3, 4};
    vector<int>(*f)(vector<int>) = sort;    //init a delegate
    arr = f(arr);   //using a delegate
    for (int i = 0; i < arr.size(); i++)
        cout << arr[i] << " ";
	system("pause");
}