using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Лабораторна_робота__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input m:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, m];
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    Console.Write("a"+(i+1)+(j+1)+" = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            Class1 ob=new Class1(n,m,arr);
            Console.WriteLine("Dobutok = ");
            Console.Write(ob.Dobutok);
            Console.WriteLine();
            Console.WriteLine("Input->Index: ");
            int k = Convert.ToInt32(Console.ReadLine());
            double sred = ob[k-1];
            Console.Write("Serednia suma = ");
            Console.WriteLine(sred);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    string s = arr[i, j].ToString();
                    Console.Write(s +"  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
