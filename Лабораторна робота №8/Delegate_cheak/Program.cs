using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events;

namespace Delegate_cheak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Samilenko Oleksandr IS-93");
            Console.Write("string = ");
            string s = Console.ReadLine();
            Cheak val = new Cheak();
            DelegeteClass del;
            del = Cheak.FindL;//Add new delegat
            Console.Write("For static mathod: ");
            if(del(s)==true)
            {
                Console.WriteLine("String has a litteral!!!");
            }
            else
            {
                Console.WriteLine("String has not a litteral!!!");
            }

            Console.Write("For examples of class: ");
            del = val.FindL2;//Add new delegate
            if (del(s) == true)
            {
                Console.WriteLine("String has a litteral!!!");
            }
            else
            {
                Console.WriteLine("String has not a litteral!!!");
            }

            DelegateClear deleg = ClearAll;//Add new method to delegat, with send to class
            Class1 value = new Class1("aasdasdsa", deleg);//Add new object of Class1 is class
            value.AddNewElement(21);//Add new value to line
            value.DeleteElement();//Delete first value in line
            value.RemoveAll();//Clear all line
            Console.ReadKey();// Stoping of a screen!
        }
        public static void ClearAll()
        {
            Console.WriteLine("Line was clear!!!");
        }
    }
}
