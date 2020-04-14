#ifndef LABA5_DERIRATIVESYMBOLS_H
#define LABA5_DERIRATIVESYMBOLS_H
#include <string>
#include "BaseString.h"
using namespace std;

class Symbols : public BaseString {
private:
    string stringSymbol;
public:
    Symbols(string userString);  // Constructor with parameter
    int StringLength() override;  // Length of the string
    void Increase() override;  // Increase by doubling all symbols
    string GetString();
};

#endif //LABA5_DERIRATIVESYMBOLS_H
