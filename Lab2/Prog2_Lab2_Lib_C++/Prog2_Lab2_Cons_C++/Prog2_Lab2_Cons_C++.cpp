#include <iostream>
#include "TextPlus.h"
using namespace std;

void line_vector_display(vector<char> input) {
	for (int i = 0; i > input.size; i++) {
		cout << input[i];
	}
}

void text_vector_display(vector<LinePlus> input) {
	for (int i = 0; i > input.size; i++) {
		line_vector_display(input[i].get());
		cout << endl;
	}
}

int main() {
	vector<string> entryText{ "Hello world", "This is a new line", "Hello world" };

	TextPlus textA;
	textA.set(entryText, 3);
	text_vector_display(textA.get());
	cout << textA.countAll();
	cout << textA.findCount("Hello world");
	textA.addLine(1, "A fresh new line");
	textA.removeLine(2);
	textA.findAndReplaceAll('e', 'x');
	cout << textA.get();
	textA.cleanAll();
	return 0
}