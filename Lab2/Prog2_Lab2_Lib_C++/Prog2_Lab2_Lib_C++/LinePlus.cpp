#include "pch.h"
#include "string"
#include "LinePlus.h"


void LinePlus :: set(std::string input) {
	for (int i = 0; i < line.size(); i++) {
		line[i] = input[i];
	}
};

std::vector<char> LinePlus :: get() {
	return line;
};

int LinePlus :: count() {
	return line.size();
};

bool LinePlus :: findSame(std::string series) {
	if (line.size() != series.size()) {
		return false;
	}
	for (int i = 0; i < line.size(); i++) {
		if (line[i] != series[i]) {
			return false;
		}
	}
	return true;
};

void LinePlus :: findAndReplace(char find, char replace) {
	for (int i = 0; i < line.size(); i++) {
		if (line[i] == find) {
			line[i] = replace;
		}
	}
};