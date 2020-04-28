#include "Expression.h"

Expression::Expression(double a, double b, double c, double d) {
    this->variable1 = a;
    if (d != 0){
        if (4 * b - c > 0){
            if (b + c / d - 1 != 0){
                this->variable2 = b;
                this->variable3 = c;
                this->variable4 = d;
            } else {
                throw "Wrong value(s) of b/c/d";
            } } else {
            throw "Wrong value(s) of b and/or c";
        } } else {
        throw "Wrong value of d";
    }
}

double Expression::GetA() {
    return this->variable1;
}
double Expression::GetB() {
    return this->variable2;
}
double Expression::GetC() {
    return this->variable3;
}
double Expression::GetD() {
    return this->variable4;
}

double Expression::GetExpressionValue() {
    if (this->variable4 == 0 || (this->variable2 + this->variable3/this->variable4 -1) == 0) {
        throw "Cannot divide by zero";
    }
    return log10(4 * this->variable2 - this->variable3) * this->variable1/(this->variable2 + this->variable3/this->variable4 - 1);
}
