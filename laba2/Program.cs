using System;
using System.Text;

namespace Mulik_laba2
{
    public class Program
    {
        public static void Main(string[] args)
        {
			Console.OutputEncoding = Encoding.UTF8;

			Mycontainer text = new Mycontainer();
			text.addstring(new Mystring("1st string"));
			text.addstring(new Mystring("2nd string"));
			text.addstring(new Mystring("3rd string"));
			text.addstring(new Mystring("4th string"));
			text.addstring(new Mystring("5th string"));

			Console.WriteLine("Mulik Rustam IS-93\n");
			Console.WriteLine("____________________________________\n\n");
			Console.WriteLine("Абстракция текста:\n\n");
			Console.WriteLine(text);
			Console.WriteLine("\n\n");
			Console.WriteLine("Введите:\n");
			Console.WriteLine("1 - чтобы добавить строку\n");
			Console.WriteLine("2 - чтобы удалить строку\n");
			Console.WriteLine("3 - чтобы очистить текст\n");
			Console.WriteLine("4 - чтобы узнать количество символов в тексте\n");
			Console.WriteLine("5 - чтобы найти нужную строку\n");
			Console.WriteLine("6 - чтобы заменить символ\n");
			Console.WriteLine("0 - чтобы прекратить работу\n");

			int x = 0;
			do
			{
				x = Convert.ToInt32(Console.ReadLine());
				if (x == 1)
				{
					Mystring add = new Mystring();
					Console.WriteLine("Введите строку которую хотите добавить:\n");
					text.addstring(add.input());   // не добавляет символы после пробела
					Console.WriteLine(text);
				}
				if (x == 2)
				{
					int del;
					Console.WriteLine("Введите номер строки которую хотите удалить:\n");
					del = Convert.ToInt32(Console.ReadLine());
					text.erase(del - 1);
					Console.WriteLine(text);
				}
				if (x == 3)
				{
					text.clear();
				}
				if (x == 4)
				{
					Console.WriteLine(text.count() + "\n");  // не считает из новых строк и после очистки
				}
				if (x == 5)
				{
					int take;
					Console.WriteLine("Введите номер строки которую хотите получить: ");
					take = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine(text.choosestr(take) + "\n");
				}
				if (x == 6)
				{
					char was, will;
					Console.WriteLine("Введите символ который хотите заменить: ");
					was = Convert.ToChar(Console.ReadLine());
					Console.WriteLine("Введите символ который его заменит: ");
					will = Convert.ToChar(Console.ReadLine());
					text.replace(was, will);  // не заменяет в новой строке
					Console.WriteLine(text);
				}
			} while (x != 0);

		}
	}
}
