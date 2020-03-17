#pragma once
#include <vector>
#include <iterator>

template <class ClassRepresentingChar>
class MyBasicString {
private:
	std::vector<ClassRepresentingChar> m_data;
public:
	MyBasicString(char const* begin = "\0") {
		auto* end = begin;
		for (; *end; end++);
		std::copy(begin, end, std::back_inserter(m_data));
	}
	auto begin() { return m_data.begin(); }
	auto end() { return m_data.end(); }
	auto begin() const { return m_data.begin(); }
	auto end() const { return m_data.end(); }
	void resize(size_t i) { m_data.resize(i); }

	friend std::ostream& operator<<(std::ostream& s, MyBasicString<ClassRepresentingChar> const& a) {
		for (auto const& c : a.m_data) s << c;
		return s;
	}

	using char_type = ClassRepresentingChar;
};
using MyString = MyBasicString<char>;