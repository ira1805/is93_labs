#pragma once
#include <string>
#include "vector"



class LinePlus
{
private:
	std::vector<char> line;

public:
	void set(std::string);

	std::vector<char> get();

	int count();

	bool findSame(std::string);

	void findAndReplace(char, char);
};

