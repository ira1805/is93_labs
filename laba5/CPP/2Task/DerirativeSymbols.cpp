#include "DerirativeSymbols.h"

Symbols::Symbols(string userString) {
    this->stringSymbol = std::move(userString);
}

int Symbols::StringLength() {
    return this->stringSymbol.length();
}

void Symbols::Increase() {
    string doubledString;
    for (int i = 0; i < StringLength(); i++){
        if (this->stringSymbol[i] == 'k'){
            doubledString += this->stringSymbol[i];
        }
        doubledString += this->stringSymbol[i];
    }
    this->stringSymbol = doubledString;
}

string Symbols::GetString() {
    return this->stringSymbol;
}
