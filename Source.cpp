#include <iostream>
#include "libruary_cpp/MyBasicStringTemplate.hpp"
#include "libruary_cpp/MyContainerTemplate.hpp"

int main() {
	MyContainer<MyString> c({
		MyString("Baranov Dmytro IS-93"),
		MyString("1. First line"),
		MyString("2. Second line")
		});
	std::cout << "Baranov Dmytro IS-93" << "\n" << "1 to add line" << "\n" << "2 to remove line" << "\n" << "3 to replace line" << "\n" << "4 to clear" << "\n" << "5 to get line amount" << "\n" << "6 to get numbers" << "\n" << "\n";
	int x = 0;
	for (auto i = 0; i < 10; i++) {
		std::cin >> x;
		if (x == 1) {
			c.push_back("3. Third line");
			std::cout << c << "\n";
		}
		if (x == 2) {
			c.erase(1);
			std::cout << c << "\n";
		}
		if (x == 3) {
			c.replace(1, MyString("line that was replaced"));
			std::cout << c << "\n";
		}
		if (x == 4) {
			c.clear();
			std::cout << c << "\n";
		}
		if (x == 5)
			std::cout << c.count() << "\n" << "\n";
		if (x == 6)
			std::cout << c.give_me_all_the_symbols_for_fucks_sake_but_numbers_only() << "\n" << "\n";
	}
	system("pause");
}