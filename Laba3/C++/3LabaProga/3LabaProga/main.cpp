//
//  main.cpp
//  3LabaProga
//
//  Created by Maksim Shershun on 25.03.2020.
//  Copyright © 2020 Maksim Shershun. All rights reserved.
//

#include <iostream>
#include <string>
#include <vector>
#include "stdio.h"

using namespace std;

class Student {
public:
    string name;
    string surname;
    string fathersname;
    
    Student(string name, string surname, string fathersname) {
        this->name = name;
        this->surname = surname;
        this->fathersname = fathersname;
    }
};

class Table {
private:
    vector<Student> table;
public:
    
    Table(vector<Student> const& students) {
        table = students;
    }
    
    void add(Student const& student) {
        table.push_back(student);
    }
    
    void show() {
        for(Student i : table) {
            cout << i.name << " " << i.surname << " " << i.fathersname << endl;
        }
    }
    
    int nechaiCounts() const {
        int counter = 0;
        for(Student i : table)
            if(i.surname == "Nechai")
                counter += 1;
        return counter;
    }
    
    auto operator[] (string name) {
        for(Student i : table)
            if(i.name == name)
                return i;
        return table.front();
    }
};

int main(int argc, const char * argv[]) {
    
    cout << "Shershun Maksim IS-93" << endl << endl;
    Table arr ({
        Student("Maksim","Shershun","Miroslavovich"),
        Student("Evgenii","Nechai","Viktorovich"),
        Student("Andrei","Kot","Vasilovich"),
        Student("Alex","Samilenko","Andriyovich"),
        Student("Georg","Nechai","Maksimovich")
    });
    
    arr.add(Student("Misha","Storoguk","Mukolayovich"));
    
    cout << "Students Table:" << endl << endl;
    arr.show();
    cout << endl;
    
    cout << "Student with name Andrei:  " << arr["Andrei"].name << " " << arr["Andrei"].surname << " " << arr["Andrei"].fathersname << endl << "Students with surname Nechai = " << arr.nechaiCounts() << endl;\
    
    return 0;
}
