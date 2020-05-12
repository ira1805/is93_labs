#include <iostream>
using namespace std;

int CountSymbol(char uSymbol, string& uString){  // Count the repetition of the character in the string
    int count = 0;
    for (char i : uString){
        if (i == uSymbol){count += 1;}
    }
    return count;
}

int main() {
    cout << "IS-93 Kravchenko Olena, 12 variant" << endl;
    string test1 = "Hello world!";  // 3 - 'l'
    string test2 = "Flood door room master";  // 6 - 'o'
    string test3 = "3,141592653589793238462643383279";  // 7- '3'
    string test4 = "step on no pets";  // 2 - 't'
    int (*funcPtr)(char, string&);
    funcPtr = CountSymbol;
    cout << funcPtr('l', test1) <<'\n'<< funcPtr('o', test2) <<'\n'<< funcPtr('3', test3) <<'\n'<<funcPtr('t', test4);
}
