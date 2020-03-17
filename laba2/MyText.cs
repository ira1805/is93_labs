using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class MyText
    {
        private List<MyString> m_data;
        public MyText()
        {
            m_data = new List<MyString>();
        }

        public void Add(MyString input)
        {
            m_data.Add(input);
        }

        public void Remove(MyString input)
        {
            m_data.Remove(input);
        }
        public void RemoveAt(int index)
        {
            m_data.RemoveAt(index);
        }

        public void Replace(int index, MyString input)
        {
            m_data[index] = input;
        }

        public void Clear()
        {
            m_data.Clear();
        }

        public int Size()
        {
            return m_data.Count;
        }

        public MyString GiveMeAllTheFuckingSymbolsYouSeeInHere()
        {
            var temp = new SortedSet<char>();
            foreach (var s in m_data)
            {
                foreach (var c in s.ToString())
                {
                    if (c >= '0' && c <= '9')
                        temp.Add(c);
                }
            }

            string output = "";
            foreach (var c in temp)
            {
                output += c;
            }

            return new MyString(output);
        }

        public override string ToString()
        {
            string output = "";
            foreach (var x in m_data)
                output += x.ToString() + '\n';
            return output;
        }
    }
}
