using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    

    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine(); //введення рядків 
            string str2 = Console.ReadLine();
            char[] arr1; //оголошуємо масиви символів
            char[] arr2;
            arr1 = str1.ToCharArray(); //ініціалізуємо їх
            arr2 = str2.ToCharArray();

            MyClass a = new MyClass(arr1); //об'єкт C2
            MyClass b = new MyClass(arr2); //об'єкт С3
            MyClass c = new MyClass(a + b); //об'єкт С1

            Console.WriteLine("C2: ");
            Console.WriteLine(a.getLine());
            Console.WriteLine("C2 length: ");
            Console.WriteLine(a.getLength());
            a = a - '5';
            Console.WriteLine("C2 without 5: ");
            Console.WriteLine(a.getLine());
            Console.WriteLine(c.getLine());
        }
    }
}