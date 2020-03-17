#include <iostream>
#include <initializer_list>
#include <set>
#include <vector>

class MyArray {
private:
	std::vector<int> m_data;
public:
	MyArray(std::vector<int> const& input) {
		m_data = input;
	}

	void add(int const& input) {
		m_data.push_back(input);
	}

	void show() {
		for (int i = 0; i < m_data.size(); i++)
			std::cout << m_data[i] << "  ";
	}
	
	int size() const { return m_data.size(); }

	auto operator[] (int i) {
		if (i >= 0 && i < m_data.size())
			return(m_data[i]);
		else
			return(1234567890);
	}
};

void main() {
	std::cout << "Baranov Dmytro IS-93" << "\n" << "\n" << "message 1234567890 means that array hasn't the element with fillen number" << "\n" << "\n";
	MyArray arr ({ 1, 2, 3, 4, 5 });
	arr.add(10);
	std::cout << "array" << "\n";
	arr.show();
	std::cout << "\n" << "\n" << "element with index 2:  " << arr[2] << 
		"\n" << "element with index -1:  " << arr[-1] << "\n" << "\n" << 
		"amount of elements:  " << arr.size() << "\n" << "\n";
	system("pause");
}