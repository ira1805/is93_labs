//
//  main.cpp
//  Laba6
//
//  Created by Maksim Shershun on 05.05.2020.
//  Copyright © 2020 Maksim Shershun. All rights reserved.
//

#include <iostream>
#include <fstream>
#include <time.h>
#include "math.h"

using namespace std;

class Expression {
    double a, b, c;
public:
    Expression(int a, int b, int c) {
        this->a = a;
        this->b = b;
        this->c = c;
    }
    
    double getA() { return a; }
    double getB() { return b; }
    double getC() { return c; }
    
    void setA(int value) { a = value; }
    void setB(int value) { b = value; }
    void setC(int value) { c = value; }
    
    double result() {
        return dividing((8 * Log10(b - 1) - c), (a * 2 + dividing(b, c)));
    }
    
    double Log10(double a) {
        double res = 0;
        try {
            if (a <= 0)
                throw runtime_error("Log10 Error");
            res = log10(a);
        } catch (runtime_error e) {
            cout << e.what() << endl;
            ofstream out("log.txt",  ios::app);
            if (out.is_open()) {
                out << e.what() <<  endl;
            }
            out.close();
        }
        return res;
    }
    
    double dividing(double a, double b) {
        double res = 0;
        
        try {
            if (b == 0)
                throw runtime_error("dividing by zero");
            res = a / b;
        } catch (runtime_error e) {
            cout << e.what() << endl;
            ofstream out("log.txt",  ios::app);
            if (out.is_open()) {
                out << e.what() <<  endl;
            }
            out.close();
        }
        return res;
    }
    
    double operator /(double b) {
        double res = 0;
        
        try {
            if (b == 0)
                throw runtime_error("dividing by zero (operator)");
            res = a / b;
        } catch (runtime_error e) {
            cout << e.what() << endl;
            ofstream out("log.txt",  ios::app);
            if (out.is_open()) {
                out << e.what() <<  endl;
            }
            out.close();
        }
        return res;
    }
};

int main() {
    Expression a[] = { Expression(1,1,1), Expression(1,2,1), Expression(1,1,0) };
    
    cout << "a[0].Result() = " << a[0].result() <<  endl;
    cout << "a[1].Result() = " << a[1].result() <<  endl;
    cout << "a[2].Result() = " << a[2].result() <<  endl;
    
    double d = a[0] / 0;
    cout << d << endl;
}
