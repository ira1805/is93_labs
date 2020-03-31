#pragma once
#include <vector>
using namespace std;

class vectorPol {
private:
	vector<double> m_data; //вектор для зберігання координат 

public:
	vectorPol() {			//конструктор за умовчуванням
		m_data.push_back(0);
		m_data.push_back(0);
	}

	vectorPol(double rad, double ang) {	//конструктор з параметрами
		m_data.push_back(rad);
		m_data.push_back(ang);
	}

	vectorPol(vectorPol& em_data) {	//конструктор копіювання
		m_data.push_back(em_data.m_data[0]);
		m_data.push_back(em_data.m_data[1]);
	}

	void rotate(double angle) { //метод повороту на кут
		m_data[1] += angle;
	}

	double getRad() {	//метод зчитування довжини
		return m_data[0];
	}

	double getAng() {	//метод зчитування кута
		return m_data[1];
	}

	vectorPol operator=(vectorPol v) {	//перегрузка оператора присвоєння
		m_data[0] = v.m_data[0];
		m_data[1] = v.m_data[1];
		return *this;
	}

	vectorPol operator/=(double x) {	//перегрузка оператора ділення
		m_data[0] = m_data[0] / x;
		return *this;
	}

	vectorPol operator+=(vectorPol v) {	//перегрузка оператора додавання
		m_data[0] += v.m_data[0];
		m_data[1] += v.m_data[1];
		return (*this);
	}

	friend ostream& operator<<(ostream& stream, vectorPol v) {	//перегрузка оператора виведення
		stream << "radius: " << v.m_data[0] << "\n"
			<< " angle: " << v.m_data[1] << "\n\n";
		return stream;
	}
};