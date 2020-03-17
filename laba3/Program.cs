using System;
using System.Collections.Generic;

namespace laba3
{
    public class MyArray
    {
        private List<int> m_data;
        public MyArray()
        {
            m_data = new List<int>();
        }

        public void Add(int input)
        {
            m_data.Add(input);
        }

        public int Size()
        {
            return m_data.Count;
        }

        public int this[int index]
        {
            get
            {
                return m_data[index];
            }
            set
            {
                m_data[index] = value;
            }
        }

        public override string ToString()
        {
            string output = "";
            foreach (var x in m_data)
                output += x.ToString() + "  ";
            return output;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            Console.WriteLine("Baranov Dmytro IS-93");
            Console.WriteLine();
            Console.WriteLine("array");
            Console.WriteLine(arr);
            Console.WriteLine();
            Console.WriteLine("fourth element");
            Console.WriteLine(arr[3]);
            Console.WriteLine();
            Console.WriteLine("size of array");
            Console.WriteLine(arr.Size());

            Console.ReadKey();
        }
    }
}
