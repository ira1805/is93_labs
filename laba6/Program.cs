using System;
using viraz;

namespace laba6cs
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Мулік Рустам ІС-93\n_______________________________________\n");
			Viraz[] arr = new Viraz[5];
			Console.WriteLine("\n\nПерший об'єкт a=0, b=0, c=0");
			arr[0] = new Viraz();
			Console.Write(arr[0].Calculator());
			Console.WriteLine("результат: " + arr[0].Result());

			Console.WriteLine("\n\nДругий об'єкт a=1, b=2, c=3");
			arr[1] = new Viraz(1, 2, 3);
			Console.Write(arr[1].Calculator());
			Console.WriteLine("результат: " + arr[1].Result());

			Console.WriteLine("\n\nТретій об'єкт a=5, b=4, c=0");
			arr[2] = new Viraz(5, 4, 0);
			Console.Write(arr[2].Calculator());
			Console.WriteLine("результат: " + arr[2].Result());

			Console.WriteLine("\n\nЧетвертий об'єкт a=3, b=-6, c=1");
			arr[3] = new Viraz(3, -6, 1);
			Console.Write(arr[3].Calculator());
			Console.WriteLine("результат: " + arr[3].Result());

			Console.WriteLine("\n\nП'ятий об'єкт a=5.4, b=8.45, c=7.35");
			arr[4] = new Viraz();
			arr[4].SetVars(5.4, 8.45, 7.35);
			Console.Write(arr[4].Calculator());
			Console.WriteLine("результат: " + arr[4].Result());

			Console.WriteLine("\n\nНові значення першого об'єкту a=2, b=21, c=0,5");
			double[] vars = { 2, 21, 0.5 };
			arr[0].abc = vars;
			Console.Write(arr[0].Calculator());
			Console.WriteLine("результат: " + arr[0].Result());

			Console.ReadKey();
		}
	}
}