#include "pch.h"
#include "string"
#include "TextPlus.h"


void TextPlus :: set(std::vector<std::string> input, int setsize) {
	for (int i = 0; i < setsize; i++) {
		LinePlus tempLine;
		tempLine.set(input[i]);
		text[i] = tempLine;
	}
};

std::vector<LinePlus> TextPlus :: get() {
	return text;
};

void TextPlus :: addLine(int index, std::string insert) {
	for (int i = text.size - 1; i > index; i--) {
		text[i + 1] = text[i];
	}
	LinePlus tempLine;
	tempLine.set(insert);
	text[index] = tempLine;
};

void TextPlus :: removeLine(int index) {
	for (int i = index; i < text.size; i++) {
		text[index] = text[index + 1];
	}
};

void TextPlus :: cleanAll() {
	text.clear();
	text.shrink_to_fit();
};

int TextPlus :: countAll() {
	int count = 0;
	for (int i = 0; i < text.size; i++) {
		count += text[i].count();
	}
	return count;
};

int TextPlus :: findCount(std::string series) {
	int count = 0;
	for (int i = 0; i < text.size; i++) {
		if (text[i].findSame(series) == true) {
			count++;
		}
	}
	return count;
};

void TextPlus :: findAndReplaceAll(char find, char replace) {
	for (int i = 0; i < text.size; i++) {
		text[i].findAndReplace(find, replace);
	}
};