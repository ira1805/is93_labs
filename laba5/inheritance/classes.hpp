#pragma once
#include <cmath>
#include <cstring>
using namespace std;

class line {	//клас лінії
protected:

	int m_x1, m_y1, m_x2, m_y2;	//координати точок

public:

	line(int x1, int y1, int x2, int y2) {	//конструктор з параметрами
		m_x1 = x1;
		m_y1 = y1;
		m_x2 = x2;
		m_y2 = y2;
	}

	double length() {	//метод знаходження відстані між точками
		return sqrt(pow(m_x2 - m_x1, 2) + pow(m_y2 - m_y1, 2));
	}
};

class section: public line {	//клас відрізку, є дочірнім класом лінії
private:

public:

	section(int x1, int y1, int x2, int y2) : line(x1, y1, x2, y2) {}	//конструктор відрізку з визовом конструктору лінії

	double angleOY() {	//знаходження кута
		return (acos((m_y2 - m_y1) / length()))*180 / 3.1415;
	}

	string getFirstCoordinates () {	//виведення координат первої точки
		return " x1: " + to_string(m_x1) + "\n y1: " + to_string(m_y1) + "\n\n";
	}

	string getSecondCoordinates() {	//виведення координат другої точки
		return " x2: " + to_string(m_x2) + "\n y2: " + to_string(m_y2) + "\n\n";
	}
};