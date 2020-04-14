#include "DerirativeNumerals.h"

Numeral::Numeral(string userString) {
    this->stringNumeral = std::move(userString);
}

int Numeral::StringLength() {
    return this->stringNumeral.length();
}

void Numeral::Increase() {
    string doubledString;
    for (int i = 0; i < StringLength(); i++){
        doubledString += this->stringNumeral[i];
        doubledString += this->stringNumeral[i];
    }
    this->stringNumeral = doubledString;
}

string Numeral::GetString() {
    return this->stringNumeral;
}
