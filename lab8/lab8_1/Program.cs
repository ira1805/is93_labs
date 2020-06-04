using System;

namespace lab8_1
{
    delegate void GetStringLengthDelegate(string str);

    class MyClass
    {
        public static void GetStringLength(string str)
        {
            Console.WriteLine("static version:" + str.Length);
        }

        public GetStringLengthDelegate StringLengthDelegate { get; set; }
    }

    class Program
    {
        static void GetStringLength(string str)
        {
            Console.WriteLine("instance version:" + str.Length);
        }
    
        static void Main(string[] args)
        {
            var str = "123h";

            //static method
            MyClass.GetStringLength(str);

            //instance + delegate
            var myClass = new MyClass();
            myClass.StringLengthDelegate = GetStringLength;
            myClass.StringLengthDelegate(str);
        }
    }
}
