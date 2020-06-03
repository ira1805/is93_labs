using System;
using System.Collections.Generic;
using System.Text;

namespace Mulik_laba2
{
    public class Mycontainer
    {
        private List<Mystring> text;
        public Mycontainer()
        {
            text = new List<Mystring>();
        }

        public void addstring(Mystring input)
        {
            text.Add(input);
        }

        public void erase(int index)
        {
            text.RemoveAt(index);
        }

        public void clear()
        {
            text.Clear();
        }

        public int count()
        {
            int count = 0;
            for (int i = 1; i < text.Count; i++)
            {
                count += text[i].Mylenght();
            }
            return count;
        }

        public Mystring choosestr(int index)
        {
            Mystring choose = new Mystring();
            choose = text[index - 1];

            return choose;
        }

        public void replace(char was, char will)
        {
            for(int i = 0; i < text.Count; i++)
		{
                text[i].replace(was, will);
            }

        }


        public override string ToString()
        {
            string output = "";
            foreach (var x in text)
                output += x.ToString() + '\n';
            return output;
        }
    }
}
