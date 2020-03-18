#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Row 
{
	string row;
public:
	Row() 
	{
		row = "";
	}
	Row(string r) 
	{
		row = r;
	}
	char operator[] (const int index)
	{
		return row[index];
	}
	int length() 
	{
		return row.length();
	}
	void set(string r) 
	{
		row = r;
	}
	string get() 
	{
		return row;
	}
};

class Text 
{
	vector <Row> rows;
public:
	Text(Row r) 
	{
		rows.push_back(r);
	}
	void append(Row r)
	{
		rows.push_back(r);
	}
	void dropLast() 
	{
		rows.pop_back();
	}
	void clearAll() 
	{
		rows.clear();
	}
	string operator[] (const int index)
	{
		Row temp = rows[index];
		return temp.get();
	}
	float getFrequencyOfCymvol(char ch) 
	{
		Row temp;
		float frequencyCym=0;
		float countCym=0;
		for (int i = 0; i < rows.size(); i++) 
		{
			temp.set(rows[i].get());
			for (int j = 0; j < temp.length(); j++) 
			{
				countCym++;
				if (temp[j] == ch) {
					frequencyCym++;
				}
			}
		}
		return frequencyCym/ countCym;
	}
	void deleteInd(int ind) 
	{
		rows.erase(rows.begin() + ind);
	}
	void replacement(int ind, Row r)
	{
		rows[ind] = r;
	}
	void dropDublicate() 
	{
		bool flag=false;
		string temp;
		for (int i = 0; i < rows.size(); i++)
		{
			temp = rows[i].get();
			for (int j = i;j < rows.size(); j++) 
			{
				for (int k = 0; k < temp.length() && k < rows[j].get().length(); k++) 
				{
					if (temp[k] != rows[j].get()[k])
					{
						flag = true;
					}
				}
			}
			if(!flag)
			{
				deleteInd(i);
			}
			flag = false;
		}
	}
	void Show() 
	{
		cout << "--------------------------------------" << endl;
		for (int i = 0; i < rows.size(); i++)
		{
			cout << rows[i].get() << endl;
		}
		cout << "--------------------------------------" << endl;
	}
};

int main() 
{
	setlocale(LC_ALL, "Russian");
	Row first("И труд нелеп, и бестолкова праздность,");
	Row second("И с плеч долой всё та же голова,");
	Row third("Когда приходит бешеная ясность,");
	Row fourth("Насилуя притихшие слова.");
	Text text(first);
	text.append(second);
	text.append(third);
	text.append(fourth);
	cout << "Демонстрація наповненості рядка" << endl;
	text.Show();
	cout << "Частота входження літери а- " << text.getFrequencyOfCymvol('а') * 100 << '%' << endl; 
	cout << "Видалимо 2 рядок" << endl;
	text.deleteInd(1);
	text.Show();
	cout << "Вставимо текст в другу строку" << endl;
	text.append(first);
	text.Show();
	cout << "Видалимо дублікати з строки" << endl;
	text.dropDublicate();
	text.Show();
	return 0;
}
