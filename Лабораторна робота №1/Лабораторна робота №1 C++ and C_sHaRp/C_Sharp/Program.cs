using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
	class Program
    {
		static void Output(int a)//Output the value в двійковій System!;
		{
			for (int mask = sizeof(int) * 8 - 1; mask >= 0; mask--)
			{
				int A = a & (1 << mask);
				if (A != 0)
				{
					A = 1;
				}
				else
				{
					A = 0;
				}
				Console.Write(A);
			}
		}
		static void Counter(ref int a)//Це функція для зменшення нашого числа на 1;
		{
			int Ai;
			for (int mask = 0; mask < sizeof(int) * 8 - 1; mask++)
			{
				Ai = (a & (1 << mask));
				if (Ai != 0) { Ai = 1; }
				if (Ai == 1)
				{
					for (int i = 0; i < mask + 1; i++)
					{
						a = a ^ (1 << i);
					}
					break;
				}
			}
		}
		static int Summa_Bit(int a, int b)//Це функція для суми двох чисел.
		{
			int Ai, Bi; int s = 0, k = 0;//Де К- це допоміжна зміна
			for (int mask = 0; mask < sizeof(int) * 8 - 1; mask++)
			{
				Ai = (a & (1 << mask));
				Bi = (b & (1 << mask));
				if (Ai != 0) { Ai = 1; }
				if (Bi != 0) { Bi = 1; }
				if (Ai + Bi + k == 1)
				{
					s = s | (1 << mask);
					k = 0;
				}
				else
				{
					if (Ai + Bi + k == 2)
					{
						k = 1;
					}
					else
					{
						if (Ai + Bi + k > 2)
						{
							k = 1;
							s = s | (1 << mask);
						}
					}
				}
				Ai = 0;
				Bi = 0;
			}
			return s;
		}
		static void Main(string[] args)
        {
			Console.WriteLine("Роботу виконав: Самiленко Олександр!!!\nГрупа: IC-93;\n Варiант - 21.\n");
			int value1;
			Console.WriteLine("Input the value for first lesson: ");
			value1 = int.Parse(Console.ReadLine());
			int b;
			Counter(ref value1 );
			Console.Write("New value = " + value1.ToString()+" = ");
			Output(value1);
			Console.WriteLine();
			int a;
			Console.WriteLine("Input values a and b  for second lesson: ");
			Console.WriteLine("Input A: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input B: ");
			b = Convert.ToInt32(Console.ReadLine());
			int s = Summa_Bit(a, b);
			Console.Write("Suma a and b = " + s+" = ");
			Output(s);
			Console.WriteLine();
			Console.ReadKey();
		}
    }
}
