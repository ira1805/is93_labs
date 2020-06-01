//Ann Sokolnytska, FICT, IS-93
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_sharp_Progect
{
	class Program
	{
		public static void Name() // выводит ФИО в консоли
		{
			Console.WriteLine("-------- IS-93 Ann Sokolnytska ---------");
		}
		public static void Menu()  // выводит меню в консоли
		{
			Console.WriteLine("------------------ Меню ------------------");
			Console.WriteLine("  1. Додати структуру");
			Console.WriteLine("  2. Додати елемент у структуру");
			Console.WriteLine("  3. Вивести кiлькiсть елементiв");
			Console.WriteLine("  4. Вивести кiлькiсть елементiв на парних мicцях ");
			Console.WriteLine("  5. Видалити елементи бiльших за А ");
			Console.WriteLine("  6. Вихiд з програми");
		}
		static unsafe void Main(string[] args)
		{
			Name();
			Menu();
			var node = new OurList();
			short c;
			Console.WriteLine("Виберiть пункт меню: ");
			c = short.Parse(Console.ReadLine());
			while (true)
			{
				int k;
				switch (c)
				{
					case 1: Console.Clear(); Name(); char b; Console.Write("Введiть перший елемент =  "); b = char.Parse(Console.ReadLine()); node = new OurList(); node.Push(b); Menu(); Console.WriteLine(" Виберiть пункт меню:  "); c = short.Parse(Console.ReadLine()); break;

					case 2: Console.Clear(); Name(); Console.Write("Елемент введення, який потрiбно додати в структуру =  "); node.Push(char.Parse(Console.ReadLine())); Menu(); Console.WriteLine(" Виберiть пункт меню: "); c = short.Parse(Console.ReadLine()); break;

					case 3: Console.Clear(); Name(); k = node.CountOfElem(); Console.WriteLine($"Кiлькiсть введених елементiв = 5"); Menu(); Console.WriteLine(" Виберiть пункт меню: "); c = short.Parse(Console.ReadLine()); break;

					case 4: Console.Clear(); Name(); node.Out_Put_Number(); Console.WriteLine("Список елементiв на парних мicцях =  "); node.OutPutList(); Menu(); Console.WriteLine(" Виберiть пункт меню:  "); c = short.Parse(Console.ReadLine()); break;

					case 5: Console.Clear(); Name(); node.OutPutList(); Menu(); Console.WriteLine(" Виберiть пункт меню: "); c = short.Parse(Console.ReadLine()); break;

					case 6: Console.Clear(); Environment.Exit(0); break;

					default:

						Console.Clear();
						Menu();
						Console.WriteLine(" Ви вводите неправильне значення елемента");
						Console.Write("Виберiть пункт меню ще раз: ");
						c = short.Parse(Console.ReadLine());
						break;
				}
			}
		}
		
	}
}