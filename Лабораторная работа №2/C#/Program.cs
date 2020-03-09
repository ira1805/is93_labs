using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextLibrary;
using StringLibrary;

namespace Laba_2_C_Sharp
{
    class Program
    {
        static void Main(string[] args)//Main function
        {
			Console.WriteLine("Samilenko Oleksandr Maksimovich IS-93");
			int n;
			Console.Write("Введите количество строк: ");
			n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите текст: ");
			MyText text = new MyText();
			for (int i = 0; i < n; i++)
			{
				char[] arr = new char[1000];
				int t = 0;
				for (int j = 0; j < 1000; j++)
				{
					char c_1 = Convert.ToChar(Console.ReadLine());
					if (c_1== '&')
					{
						break;
					}
					arr[t] = c_1;
					t++;
				}
				MyString s = new MyString();
				s.GetStr(arr);
				text.AddStr_2(s);
			}
			int c;
			Menu();
			Console.Write("Выберите пункт меню:");
			c = Convert.ToInt32(Console.ReadLine());
			while (true)
			{
				switch (c)
				{
					case 1: Console.Clear(); AddString(text); Menu(); Console.Write("Выберите пункт меню:"); c = Convert.ToInt32(Console.ReadLine()); break;//+
					case 2: Console.Clear(); Console.Write("Введите номер строки для удаления: ");int c1 = Convert.ToInt32(Console.ReadLine()); text.DeleteStr_2(c1); Menu(); Console.Write("Выберите пункт меню:"); c = Convert.ToInt32(Console.ReadLine()); break;
					case 3: Console.Clear(); text.DeleteText_2(); Menu();	Console.Write("Выберите пункт меню:"); c = Convert.ToInt32(Console.ReadLine());break;//+
					case 4: Console.Clear(); LettersCount(text); Menu(); Console.Write("Выберите пункт меню:"); c = Convert.ToInt32(Console.ReadLine());break;//+
					case 5: Console.Clear(); OutputStringFirstLatters(text); Menu(); Console.Write("Выберите пункт меню:"); c = Convert.ToInt32(Console.ReadLine()); break;//+
					case 6: Console.Clear(); MinString(text); Menu(); Console.Write("Выберите пункт меню:"); c = Convert.ToInt32(Console.ReadLine()); break;	//+!;
					case 7: Console.Clear(); OutputText(text); Menu(); Console.Write("Выберите пункт меню:"); c = Convert.ToInt32(Console.ReadLine());break;
					case 8: Console.WriteLine("Press to some button");  Console.ReadKey(); Environment.Exit(0); break;//+
					default:
						break;
				}
			}
		}
		/*static MyString inputString(int n)//Input the string
		{
			Console.Write("Enter your string: ");
			char[] input = new char[n];
			for (int i = 0; i < n; i++)
			{
				char temp = Console.ReadKey().KeyChar;
				if (i > 0 && temp == 13)
					break;
				input[i] = temp;
			}
			Console.WriteLine();

			return new MyString(input);
		}*/
		static void Menu()//Output the menu
		{
			Console.WriteLine("Menu:");
			Console.WriteLine("1.Добавить строку.\n2.Удалить строку.");
			Console.WriteLine("3.Удалить весь текст.");
			Console.WriteLine("4.Найти количество вхождений символа...");
			Console.WriteLine("5.Вывести строку, которая состоит из первых символом каждой строки.");
			Console.WriteLine("6.Вывести строку, которая имеет минимальную длину.");
			Console.WriteLine("7.Вывести текст.");
			Console.WriteLine("8.Выйти из программы.");
		}
		static void AddString(MyText text)// Add the string
		{
			Console.WriteLine("Введите новую строку: ");
			for (int i = 0; i < 1; i++)
			{
				char[] arr = new char[1000];
				int t = 0;
				for (int j = 0; j < 1000; j++)
				{
					char c = Convert.ToChar(Console.ReadLine());
					if (c == '&')
					{
						break;
					}
					arr[t] = c;
					t++;
				}
				MyString s = new MyString();
				s.GetStr(arr);
				text.AddStr_2(s);
			}
		}
		static void OutputText(MyText text)//Output the text
		{
			Console.WriteLine("My text:");
			for (int i = 0; i < text.count; i++)
			{
				text.arrgs[i].outputString();
				Console.WriteLine();
			}
		}
		static void MinString(MyText text)// Find min string
		{
			char[]str= new char[1000];
			text.MinStr_2(str);
			Console.Write("Минимальная строка:"+" ");
			for (int i = 0; i < str.Length; i++)
			{
				if(str[i]!= default(char))
				{
					Console.Write(str[i]);
				}
				else
				{
					break;
				}
			}
			Console.WriteLine();
		}
		static void OutputStringFirstLatters(MyText text)// Output first string
		{
			char[] str = new char[1000];
			text.FirstChars_2(str);
			Console.WriteLine("String: ");
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] != default(char))
				{
				    Console.Write(str[i]);
				}
				else
				{
					break;
				}
			}
			Console.WriteLine();
		}
		static void LettersCount(MyText text)//Count letter
		{
			Console.Write("Input символ: ");
			char c = Convert.ToChar(Console.ReadLine());
			int k = 0;
			Console.Write("Noumbers :  ");
			k = text.CharCountInTextAndStr_2(c);
			Console.WriteLine(k);
		}
	}
}
