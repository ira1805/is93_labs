#pragma once
#include <string>
using namespace std; 

class myString {
public:
	virtual int length() = 0;
	virtual void sort() = 0;
};

class uppercas : public myString {
private:
	string m_data;

public:
	uppercas(string s) {
		m_data = s;
	}

	int length() {
		return m_data.length();
	}

	void sort() {
		string s = m_data;
		int i, j;
		char temp;

		for (i = 0; i < m_data.length() - 1; i++)
			for (j = 0; j < m_data.length() - i - 1; j++)
				if (s[j] > s[j + 1]) {
					temp = s[j];
					s[j] = s[j + 1];
					s[j + 1] = temp;
				}

		cout << s;
	}
};

class lowercase : public myString {
private:
	string m_data;

public:
	lowercase(string s) {
		m_data = s;
	}

	int length() {
		return m_data.length();
	}

	void sort() {
		string s = m_data;
		int i, j;
		char temp;

		for (i = 0; i < m_data.length() - 1; i++)
			for (j = 0; j < m_data.length() - i - 1; j++)
				if (s[j] < s[j + 1]) {
					temp = s[j];
					s[j] = s[j + 1];
					s[j + 1] = temp;
				}

		cout << s;
	}
};