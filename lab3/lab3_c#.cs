using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Text
    {
        private List<String>  text = new List<String>{};
        public Text(String s) 
        {
            text.Add(s);
        }
        public void append(String r)
        {
            text.Add(r);
        }
        public void dropLast()
        {
            text.RemoveAt(text.Count - 1);
        }
        void clearAll()
        {
            text.Clear();
        }
        public String this[int index]
        {
            get
            {
                return text[index];
            }
        }
        public void deleteInd(int ind)
        {
            text.RemoveAt(ind);
        }
        public void replace(String r, int i)
        {
            text[i] = r;
        }
        public int size
        {
            get
            {
                return text.Count;
            }

        }
        public void Show()
        {
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < text.Count; i++)
            {
                Console.WriteLine(text[i]);
            }
            Console.WriteLine("--------------------------------------");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            String first = "И труд нелеп, и бестолкова праздность,";
            String second ="И с плеч долой всё та же голова,";
            String third = "Когда приходит бешеная ясность,";
            String fourth ="Насилуя притихшие слова.";
            Text text = new Text(first);
            text.append(second);
            text.append(third);
            text.append(fourth);
            Console.WriteLine("Вивід рядка");
            text.Show();
            Console.WriteLine("Кількість рядків - {0}",text.size);
            Console.WriteLine("Отримуємо другу строку в тексті, звернувшись до обєкта класу по індексу");
            Console.WriteLine(text[1]);
        }
    }
}
