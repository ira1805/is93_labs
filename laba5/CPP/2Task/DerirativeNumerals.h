#ifndef LABA5_DERIRATIVENUMERALS_H
#define LABA5_DERIRATIVENUMERALS_H
#include <string>
#include <utility>
#include "BaseString.h"
using namespace std;

class Numeral : public BaseString{
private:
    string stringNumeral;
public:
    Numeral(string userString);  // Constructor with parameter
    int StringLength() override;  // Length of the string
    void Increase() override;  // Increase by doubling all symbols
    string GetString();
};

#endif //LABA5_DERIRATIVENUMERALS_H
