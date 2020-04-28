#ifndef LABA6_EXPRESSION_H
#define LABA6_EXPRESSION_H
#include <cmath>

class Expression {
private:
    double variable1, variable2, variable3, variable4;  // a,b,c,d
public:
    Expression(double a, double b, double c, double d);  // Constructor with variables for expression
    double GetA();  // Get value of A
    double GetB();  // Get value of B
    double GetC();  // Get value of C
    double GetD();  // Get value of D
    double GetExpressionValue();  // Calculate expression from the task
};


#endif //LABA6_EXPRESSION_H
