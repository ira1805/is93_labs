#include <iostream>
#include <vector>
#include <stdio.h>

using namespace std;

class MyString 
{
public: 
    char* mystring = new char[0];
      MyString(char* myString) 
      {
          this->mystring = myString;
      }
};

class Tekst
{
public: int size = 0;
        vector<MyString> text;

public:
    //Добавка строки
    void addRow(MyString textToAdd)
    {
        text.push_back(textToAdd);
    }
    //Видалення вдаленої строки
    void deleteRow(int rawToDelete)
    {
        text.erase(text.begin() + rawToDelete - 1);
    }
    //Очищення тексту
    void clearText()
    {
        text.erase(text.begin(), text.end());
    }
    //Найбліьший рядок
    MyString ThebiggestRow()
    {
        int biggest = strlen(text[0].mystring);
        int biggestIndex = 0;
        for (int i = 0; i < text.size(); i++) {
            if (strlen(text[i].mystring) > biggest) {
                biggestIndex = i;
            }
        }

        return text[biggestIndex].mystring;
    }
    //К-сть строк
    int NumberofStroks()
    {
        int counter = 0;
        for (int i = 0; i < text.size(); i++)
            counter++;
        return counter;
    }
    //Строка з цифр
    MyString NumberofNumerStrocs()
    {
        int indexNumerRow = 0;

        for (int i = 0; i < text.size(); i++)
        {
            for (int j = 0; j < strlen(text[i].mystring); j++)
            {
                if (text[i].mystring[j] > 47 && text[i].mystring[j] < 58)
                    indexNumerRow = i;
            }
        }
        return text[indexNumerRow].mystring;
    }

    };


    int main(int argc, const char* argv[])
    {
        setlocale(LC_ALL, "eng");
        int numb, count = 0;
        Tekst text;
        int countRows = 0;
        string start;
        //Введіть к-сть рядків
        cout << "Enter amount of raws: ";
        cin >> countRows;
        //Алгоритм заповнення
        for (int i = 0; i < countRows; i++) {
            cout << "Enter " << i + 1 << " raw: ";
            cin >> start;
            char* array = new char[start.length()];

            for (int i = 0; i < strlen(array); i++)
                array[i] = start[i];
            text.addRow(array);
            start = "";
        }

        cout << "Enter rows :" << endl;

        for (MyString i : text.text) {
            cout << i.mystring << endl;
        }
        cout << "---------------------------" << endl;
        //К-сть рядків/найбільший елмент
        cout << "Number of rows = " << text.NumberofStroks() << endl;
        cout << "Biggest row is = "; 
        cout << text.ThebiggestRow().mystring << endl;
        //Введіть рядок для видалення
        cout << "Enter deleted row = " ;
        cin >> numb;
        text.deleteRow(numb);
        cout << "\nAfter deleteting " << numb << " row" << endl;
        for (MyString i : text.text) {
            cout << i.mystring << endl;
        }
        cout << "---------------------------" << endl;
        cout << "\nBiggest row = " ;
        cout << text.ThebiggestRow().mystring << endl;
        cout << "Number of rows = " << text.NumberofStroks() << endl;
        cout << "Row of digit = " << text.NumberofNumerStrocs().mystring << endl;
        cout << "\nAfter cleaning" << endl;
        //Почистили
        text.clearText();
        for (MyString i : text.text) 
        {
            cout << i.mystring << endl;
        }
        return 0;
 }
