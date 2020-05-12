using System;
using System.Collections.Generic;
using SortClassNamespace;
using CarNamespace;

namespace laba8_oop_cs
{
    class Program
    {
        delegate List<int> Sort(List<int> arr);
        static void Main(string[] args)
        {
            List<int> arr = new List<int>(7);
            string s = "";
            arr.Add(6);
            arr.Add(1); 
            arr.Add(7); 
            arr.Add(9); 
            arr.Add(2); 
            arr.Add(3); 
            arr.Add(4);
            for (int i = 0; i < arr.Count; i++)
                s += arr[i] + " ";
            Console.WriteLine("Baranov Dmytro IS-93\n\n\ninput array: " + s);
            s = "";
            arr = SortClass.SortStatic(arr);
            for (int i = 0; i < arr.Count; i++)
                s += arr[i] + " ";
            Console.WriteLine("\nstatic method result: " + s);
            s = "";
            arr.Clear();
            arr.Add(6);
            arr.Add(1);
            arr.Add(7);
            arr.Add(9);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            SortClass exemp = new SortClass();
            Sort del = exemp.SortDynamic;
            arr = del(arr);
            for (int i = 0; i < arr.Count; i++)
                s += arr[i] + " ";
            Console.WriteLine("\ndelegate result: " + s + "\n\n\n//////////car//////////\n\n");

            ////////////////////////////////////////////////////////

            Console.WriteLine("1 - add 5 units of fuel\n2 - go\n3 - stop\n0 - exit");
            string manip = "";
            Car c = new Car(); //init Car class instance
            c.check += c.CheckFuel; //add event listener
            
            for (int i = 0; i < 100; i++)
            {
                manip = Console.ReadLine();
                if (manip == "1")
                {
                    c.AddFuel(5);
                }
                else if (manip == "2")
                {

                    c.Go();
                }
                else if (manip == "3")
                {
                    c.Stop();
                }
                else if (manip == "0")
                {
                    break;
                }
            }
        }
    }
}
