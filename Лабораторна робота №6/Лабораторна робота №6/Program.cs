using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expression;

namespace Лабораторна_робота__6
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpressionClass[] obj = new ExpressionClass[5];// Make arrg out objects
            obj[0] = new ExpressionClass(1, 2, 3, 41);
            obj[1] = new ExpressionClass(5, 2, 3, 2);
            obj[2] = new ExpressionClass(4, 2, 5, 10);
            obj[3] = new ExpressionClass(1, 41, 12, 20);
            obj[4] = new ExpressionClass(4, 13, 3, 15);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Value {i + 1} = {Math.Round(obj[i].Value(),5)}");//Output value each object
            }
            Console.ReadKey();
        }
    }
}