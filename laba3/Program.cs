using System;
using System.Collections.Generic;

namespace laba3
{
    public class MyArray
    {
        private List<int> m_data;       //створення змінних, що зберігають дані класса
        private int m_size = 0;
        public MyArray()                //конструктор
        {
            m_data = new List<int>();   //присвоєння значення пустого списку змінній
        }

        public void Add(int input)  //метод додавання
        {
            m_data.Add(input);      //додавання елементу в масив
            m_size += 1;            //інкрементація змінної розмірності
        }

        public int Size             //властивість виведення розміру
        {
            get
            {
                return m_size;      //виведення змінної, що відповідає за розмір
            }
        }

        public int this[int index]  //індексатор
        {
            get
            {
                if (index >= 0 && index < m_data.Count) //умова не порушення границі масиву
                {
                    return m_data[index];               //повернення елемента масиву
                }
                else                                    //випадок порушення границі
                {
                    return (1234567890);                //повернення помилки
                }
                
            }
            set
            {
                m_data[index] = value;                  //зміна елемента масиву за індексом
            }
        }

        public override string ToString()               //метод для виведення вмісту
        {
            string output = "";
            foreach (var x in m_data)                   //цикл виведення вмісту
                output += x.ToString() + "  ";
            return output;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray();                //створення класу
            arr.Add(1);                                 //заповнення класу
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            Console.WriteLine("Baranov Dmytro IS-93");
            Console.WriteLine();
            Console.WriteLine("message 1234567890 means error");
            Console.WriteLine();
            Console.WriteLine("array");
            Console.WriteLine(arr);
            Console.WriteLine();
            Console.WriteLine("fourth element");
            Console.WriteLine(arr[3]);
            Console.WriteLine();
            Console.WriteLine("sixth element");
            Console.WriteLine(arr[5]);
            Console.WriteLine();
            Console.WriteLine("size of array");
            Console.WriteLine(arr.Size);

            Console.ReadKey();
        }
    }
}
