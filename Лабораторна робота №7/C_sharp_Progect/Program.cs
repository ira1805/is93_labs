using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Progect
{
	class Program
	{
		static unsafe void Main(string[] args)
		{
			Name();
			Menu();
			var node = new OurList();
			short c;
			Console.WriteLine("Select an item of menu ");
			c = short.Parse(Console.ReadLine());
			while (true)
			{
				int k;
				switch (c)
				{
					case 1: Console.Clear(); Name(); short b; Console.Write("Input first element = "); b = short.Parse(Console.ReadLine()); node = new OurList(); node.Push(b); Menu(); Console.WriteLine("Select an item of menu "); c = short.Parse(Console.ReadLine()); break;
					case 2: Console.Clear(); Name(); Console.Write("Input element, wich you want to add in struct = "); node.Push(short.Parse(Console.ReadLine())); Menu(); Console.WriteLine("Select an item of menu "); c = short.Parse(Console.ReadLine()); break;
					case 3: Console.Clear(); Name(); k = node.CountOfElem(); Console.WriteLine($"Count of elements with multiples of four = {k}"); Menu(); Console.WriteLine("Select an item of menu "); c = short.Parse(Console.ReadLine()); break;
					case 4: Console.Clear(); Name(); node.ExchangeForZero(); Console.WriteLine("List of elements: "); node.OutPutList(); Menu(); Console.WriteLine("Select an item of menu  "); c = short.Parse(Console.ReadLine()); break;
					case 5: Console.Clear(); Name(); node.OutPutList(); Menu(); Console.WriteLine("Select an item of menu  "); c = short.Parse(Console.ReadLine()); break;
					case 6: Console.Clear(); Environment.Exit(0); break;
					default:
						Console.Clear();
						Menu();
						Console.WriteLine("You inputed not right value of the item!");
						Console.Write("Select an item of menu again: ");
						c = short.Parse(Console.ReadLine());
						break;
				}
			}
		}
		public static void Name()//Output my name and sername, and noubmer of group
		{
			Console.WriteLine("Samilenko Oleksandr IS-93");
		}
		public static void Menu()//Output menu
		{
			Console.WriteLine("Menu");
			Console.WriteLine("1. Create new a struct");
			Console.WriteLine("2. Add element in struct");
			Console.WriteLine("3. Find count of elemnts, wich multiples of four");
			Console.WriteLine("4. Switch element on positions wich multiples of two for 0!!");
			Console.WriteLine("5. Output our list");
			Console.WriteLine("6. Exit from programm");
		}
	}
}