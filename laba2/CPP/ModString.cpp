#include "ModString.h"
using namespace std;

ModString::ModString(vector<char> letters) {
    this->modString.swap(letters);
}

void ModString::DeleteBegAndEnd() { // Delete the first and the last elements of the string
    vector<char> changedString (this->modString.size()-2);
    int index = 0; // Index for changed string
    for (int i = 1; i < this->modString.size()-1; i++){
        changedString[index] = this->modString[i];
        index++;
    }
    this->modString.swap(changedString);
}

int ModString::ConsonantsAmount() {
    int consonantsAmount = 0;
    vector<char> vowels = {'a','i','o','e','u','y'};
    for (char element: this->modString){
        if (find(vowels.begin(), vowels.end(), element) == vowels.end()){
            consonantsAmount += 1;
        }
    }
    return consonantsAmount;
}

int ModString::ModLength() {
    return this->modString.size();
}

void ModString::DeleteRepeatSpaces() {
    vector<char> changedString;
    for (int index = 0; index < this->modString.size(); index++){
        if (this->modString[index] != ' '){
            changedString.push_back(this->modString[index]);
        } else if (this->modString[index] == this->modString[-1]) {
            changedString.push_back(this->modString[index]);
            break; // Next condition will throw an error if we wouldn't stop our loop
        } else if (this->modString[index] == ' ' && this->modString[index + 1] != ' '){
            changedString.push_back(this->modString[index]);
        }
    }
    this->modString.swap(changedString);
}

void ModString::GetContent() {
    for (char element: this->modString){
        cout << element;
    }
    cout << '\n';
}



