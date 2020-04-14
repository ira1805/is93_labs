//
//  main.cpp
//  Programming5Laba
//
//  Created by Maksim Shershun on 15.04.2020.
//  Copyright © 2020 Maksim Shershun. All rights reserved.
//

#include <iostream>
#include <string.h>

using namespace std;

//MARK: 1 Task
class Raw {
public:
    Raw() {};
    Raw(string raw) {
        this->raw = raw;
    }
    
    int length() {
        return raw.length();
    }
    
    void printRaw() {
        cout << raw << endl;
    }
protected:
    string raw = "";
};

class NumberRaws: public Raw {
public:
    NumberRaws() {};
    NumberRaws(string numbersRaw) {
        this->raw = numbersRaw;
    }
    
    void removeSymbol(char symbol) {
        raw.erase(remove(raw.begin(), raw.end(), symbol), raw.end());
    }
};

//MARK: 2 Task

class Figura {
public:
    Figura() {};
protected:
    virtual double perimeter() {
        return 0;
    }
    
    virtual double square() {
        return 0;
    }
};

class Trapeze: Figura {
public:
    double a = 0;
    double b = 0;
    double c = 0;
    double d = 0;
    double height = 0;
    
    Trapeze() {};
    Trapeze(double a, double b, double c, double d, double height) {
        this->a = a;
        this->b = b;
        this->c = c;
        this->d = d;
        this->height = height;
    };
    
    virtual double perimeter() {
        return a+b+c+d;
    }
    
    virtual double square() {
        return (a+b)/2 * height;
    }
};

class Circle: Figura {
public:
    double radius = 0;
    Circle() {};
    Circle(double radius) {
        this->radius = radius;
    };
    
    virtual double perimeter() {
        return 2 * 3.14 * radius;
    }
    
    virtual double square() {
        return 3.14 * radius * radius;
    }
};

int main(int argc, const char * argv[]) {
    
    cout << "Shershun Maksim IS-93" << endl << endl;
    
    //MARK: 1 Task
    
    cout << "1 Task" << endl;
    NumberRaws numbers = NumberRaws("123456789987654321");
    numbers.printRaw();
    cout << "Current length of raw is " << numbers.length() << endl;
    numbers.removeSymbol('1');
    numbers.printRaw();
    cout << "Length of raw after removing 1 symbols is " << numbers.length() << endl << endl << endl << endl;
    
    
    //MARK: 2 Task
    cout << "2 Task" << endl;
    Trapeze trapeze = Trapeze(5.6, 8.4, 6.6, 5.2, 4);
    cout << "Trapeze perimeter is " << trapeze.perimeter() << endl;
    cout << "Trapeze square is " << trapeze.square() << endl << endl;
    
    Circle circle = Circle(5.5);
    cout << "Circle perimeter is " << circle.perimeter() << endl;
    cout << "Circle square is " << circle.square() << endl << endl;
    
    return 0;
}

