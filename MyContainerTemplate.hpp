#pragma once
#include <initializer_list>
#include <set>

template <class ContainedObjectClass>
class MyContainer {
private:
	std::vector<ContainedObjectClass> m_data;
public:
	MyContainer(std::initializer_list<ContainedObjectClass> const& input) {
		std::copy(input.begin(), input.end(), std::back_inserter(m_data));
	}
	void append(MyContainer<ContainedObjectClass> const& other) {
		std::copy(other.begin(), other.end(), std::back_inserter(m_data));
	}

	void push_back(ContainedObjectClass const& input) {
		m_data.push_back(input);
	}
	void clear() { m_data.clear(); }
	auto size() const { return m_data.size(); }

	void erase(typename std::vector<ContainedObjectClass>::iterator const& i) {
		m_data.erase(i);
	}
	void erase(size_t index) { erase(begin() + index); }

	void erase(typename std::vector<ContainedObjectClass>::iterator const& from,
		typename std::vector<ContainedObjectClass>::iterator const& to) {
		m_data.erase(from, to);
	}
	void erase(size_t from, size_t to) { erase(begin() + from, begin() + to); }

	void replace(typename std::vector<ContainedObjectClass>::iterator& it,
		ContainedObjectClass const& value) {
		*it = value;
	}
	void replace(size_t index, ContainedObjectClass const value) {
		replace(begin() + index, value);
	}

	int count() {
		return m_data.size();
	}

	template<class Lambda>
	auto inner_give_me_all_the_symbols_for_fucks_sake(Lambda condition) const {
		std::set<typename ContainedObjectClass::char_type> temp;

		for (auto& s : m_data)
			for (auto& c : s)
				if (condition(c))
					temp.insert(c);

		ContainedObjectClass ret;
		ret.resize(temp.size());
		std::copy(temp.begin(), temp.end(), ret.begin());
		return ret;
	}
	auto give_me_all_the_symbols_for_fucks_sake() const {
		return inner_give_me_all_the_symbols_for_fucks_sake(
			[](typename ContainedObjectClass::char_type c) -> bool { return true; }
		);
	}
	auto give_me_all_the_symbols_for_fucks_sake_but_numbers_only() const {
		return inner_give_me_all_the_symbols_for_fucks_sake(
			[](typename ContainedObjectClass::char_type c) -> bool { return c >= '0' && c <= '9'; }
		);
	}

	auto begin() { return m_data.begin(); }
	auto end() { return m_data.end(); }
	auto begin() const { return m_data.begin(); }
	auto end() const { return m_data.end(); }

	friend std::ostream& operator<<(std::ostream& s, MyContainer<ContainedObjectClass> const& a) {
		for (auto const& c : a.m_data) s << c << '\n';
		return s;
	}

	using inner_type = ContainedObjectClass;
};