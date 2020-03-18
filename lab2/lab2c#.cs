using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Row
    {
        private String row;
        public Row()
        {
            row = "";
        }
        public Row(String r)
        {
            row = r;
        }
        public int length()
        {
            return row.Length;
        }
        public void set(String r)
        {
            row = r;
        }
        public char this[int index]
        {
            get
            {
                return row[index];
            }
        }
        public String get()
        {
            return row;
        }
    }
    class Text
    {
        private List<Row> text = new List<Row> { };
        public Text(Row r)
        {
            text.Add(r);
        }
        public void append(Row r)
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
        public Row this[int index]
        {
            get
            {
                return text[index];
            }
            set
            {
                text[index] = value;
            }
        }
        public float getFrequencyOfCymvol(char ch)
        {
            Row temp = new Row();
            float frequencyCym = 0;
            float countCym = 0;
            for (int i = 0; i < text.Count; i++)
            {
                temp.set(text[i].get());
                for (int j = 0; j < temp.length(); j++)
                {
                    countCym++;
                    if (temp[j] == ch)
                    {
                        frequencyCym++;
                    }
                }
            }
            return frequencyCym / countCym;
        }
        public void deleteInd(int ind)
        {
            text.RemoveAt(ind);
        }
        public void replace(Row r, int i)
        {
            text[i] = r;
        }
        public void dropDublicate()
        {
            bool flag = false;
            string temp;
            for (int i = 0; i < text.Count; i++)
            {
                temp = text[i].get();
                for (int j = i; j < text.Count; j++)
                {
                    for (int k = 0; k < temp.Length && k < text[j].get().Length; k++)
                    {
                        if (temp[k] != text[j].get()[k])
                        {
                            flag = true;
                        }
                    }
                }
                if (!flag)
                {
                    deleteInd(i);
                }
                flag = false;
            }
        }
        public void Show()
        {
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < text.Count; i++)
            {
                Console.WriteLine(text[i].get());
            }
            Console.WriteLine("--------------------------------------");
        }
    }
class Program
    {
        static void Main(string[] args)
        {
            Row first = new Row("И труд нелеп, и бестолкова праздность,");
            Row second= new Row("И с плеч долой всё та же голова,");
            Row third = new Row("Когда приходит бешеная ясность,");
            Row fourth= new Row("Насилуя притихшие слова.");
            Text text = new Text(first);
            text.append(second);
            text.append(third);
            text.append(fourth);
            Console.WriteLine("Демонстрація рядка");
            text.Show();
            Console.WriteLine("Частота входження літери а - {0}%",text.getFrequencyOfCymvol('а') * 100);
            Console.WriteLine("Видалимо 2 рядок");
            text.deleteInd(1);
            text.Show();
            Console.WriteLine("Вставимо текст в перший рядок");
            text.append(first);
            text.Show();
            Console.WriteLine("Видалимо рядки, які повторюються");
            text.dropDublicate();
            text.Show();
        }
    }
}
