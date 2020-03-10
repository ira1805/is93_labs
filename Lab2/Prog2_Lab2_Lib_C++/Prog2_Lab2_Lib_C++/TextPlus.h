#pragma once
#include "pch.h"
#include "LinePlus.h"
#include <vector>

class TextPlus
{
private:
	std::vector<LinePlus> text;

public:
	void set(std::vector<std::string>, int);

	std::vector<LinePlus> get();

	void addLine(int, std::string);

	void removeLine(int);

	void cleanAll();

	int countAll();

	int findCount(std::string);

	void findAndReplaceAll(char, char);
};

