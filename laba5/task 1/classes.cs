using System;
using System.Linq;

namespace classes
{
	class Strings  //клас рядка
	{
		protected string str;   //рядок
		public Strings(string inp) //конструктор з параметрами
		{
			str = inp;
		}

		public int Length()  //метод отримання довжини рядка
		{
			return str.Length;
		}
	}

	class SymbolStrings : Strings //клас символьного рядка, є дочірнім класом рядка
	{
		public SymbolStrings(string inp) : base(inp) { }   //конструктор символьного рядка з визовом конструктору звичайного рядка

		public string Sort() //метод сортування рядка за спаданням
		{
			return string.Concat(str.OrderByDescending(x => x).ToArray());
		}

		public string GetStr() //метод отримання рядка
		{
			return "символьний рядок: " + str;
		}

	}
}