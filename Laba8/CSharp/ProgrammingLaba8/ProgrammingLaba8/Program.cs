using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace ProgrammingLaba8
{
    public class MyList<T>
    {
        public delegate void ClearHandler(string message);
        public delegate bool MyDelegate(string s);

        public static event ClearHandler Notify = DisplayMessage;

        static T[] data;

        public MyList(T[] s)
        {
            data = s;
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static bool staticMethod(string str)
        {
            int numbers = 0, symbols = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 67 && str[i] <= 90 || str[i] >= 97 && str[i] <= 122)
                {
                    symbols++;
                }
                else if (str[i] >= 48 && str[i] <= 57)
                {
                    numbers++;
                }
            }
            return symbols > numbers ? true : false;
        }

        public bool notStaticMethod(string str)
        {
            int numbers = 0, symbols = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 67 && str[i] <= 90 || str[i] >= 97 && str[i] <= 122)
                {
                    symbols++;
                }
                else if (str[i] >= 48 && str[i] <= 57)
                {
                    numbers++;
                }
            }
            return symbols > numbers ? true : false;
        }

        public delegate void clear();
        public static clear ClearS = () => { data = new T[] { }; Notify?.Invoke($"Clear()"); };
        public clear ClearE = () => { data = new T[] { }; Notify?.Invoke($"Clear()"); };

        public T this[int i] { get => data[i]; set => data[i] = value; }
    }

    delegate bool MyDelegate(string s);

    class Program
    {

        static bool Method(string str)
        {
            int numbers = 0, symbols = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 67 && str[i] <= 90 || str[i] >= 97 && str[i] <= 122)
                {
                    symbols++;
                }
                else if (str[i] >= 48 && str[i] <= 57)
                {
                    numbers++;
                }
            }
            return symbols > numbers ? true : false;
        }

        static void Main(string[] args)
        {
            var value = "dqwe12edq124t1264t6812t4t12t4861wed12";
            MyDelegate mydelegate = Method;
            Console.WriteLine("program: str > numbers ? = {0}", mydelegate(value));

            MyList<string> mylist = new MyList<string>(new string[] { "one", "two", "three" });
            MyList<string>.ClearS();
            MyList<string>.MyDelegate static_delegate = MyList<string>.staticMethod;
            MyList<string>.MyDelegate non_static_delegate = mylist.notStaticMethod;

            Console.WriteLine("static method: str > numbers ? = {0}", static_delegate(value));
            Console.WriteLine("non static method: str > numbers ? = {0}", non_static_delegate(value));
        }
    }
}
