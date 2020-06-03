#pragma once
#include <cmath>
#include <string>
#include <stdexcept>
#include <iostream>
using namespace std;

class expression {
private:

	double a, c, d, res = 1;
	bool flag = 1;

public:

	expression() {
		d = c = a = 0;
	}

	expression(double u_a, double u_c, double u_d) {
		if ((u_a < 0) || (u_a == 4))
			throw new invalid_argument("invalid 'a' value");
		a = u_a;
		c = u_c;
		d = u_d;
	}

	string getVariables() {
		return to_string(a) + " " + to_string(c) + " " + to_string(d) + "\n";
	}

	string getRes() {
		return to_string(res) + "\n";
	}

	void setVariables(double u_a, double u_c, double u_d) {
		if ((u_a < 0) || (u_a == 4))
			throw new invalid_argument("invalid 'a' value");
		a = u_a;
		c = u_c;
		d = u_d;
	}

	string calculate() {
		try {
			if ((a < 0) || (a == 4))
				throw invalid_argument("invalid 'a' value, result can't be calculated");
			else
				throw 1;
		}
		catch (invalid_argument ex) {
			flag = 0;
			return ex.what();
		}
		catch (int) {
			flag = 1;
			this->res = (2 * c - d + sqrt(23 * a)) / (a / 4 - 1);
			return "OK";
		}
	}

	string result() {
		try {
			if (flag)
				throw 1;
			else
				throw invalid_argument("result wasn't calculated");
		}
		catch (invalid_argument ex) {
			return ex.what();
		}
		catch (int) {
			double dres = (2 * c - d + sqrt(23 * a)) / (a / 4 - 1);
			return to_string(dres);
		}
	}
};