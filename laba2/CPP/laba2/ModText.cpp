#include "ModText.h"
using namespace std;

void ModText::AddToText(vector<char> chars) {
    ModString word = ModString(chars);
    this->text.push_back(word);
}

void ModText::ClearText() {
    this->text.clear();
}

int ModText::SmallestLength() {
    int minimum = this->text[0].ModLength();
    for (ModString element: this->text){
        if (element.ModLength() < minimum){
            minimum = element.ModLength();
        }
    }
    return minimum;
}

void ModText::DeleteSpaces(int index) {
    this->text[index-1].DeleteBegAndEnd();
}

int ModText::ConsonantsPercent() {
    double textLength = 0;
    double allConsonantsAmount = 0;
    for (ModString element: this->text){
        textLength += element.ModLength();
        allConsonantsAmount += element.ConsonantsAmount();
    }
    double result = (allConsonantsAmount/textLength)*100;
    return round(result);
}

void ModText::DeleteString(int index) {
    this->text.erase(this->text.begin() + (index-1));
}

void ModText::DeleteRepeatedSpaces() {
    for(ModString userString: this->text){
        userString.DeleteRepeatSpaces();
    }
}

void ModText::GetContent() {
    for(ModString element: this->text){
        element.GetContent();
    }
}
