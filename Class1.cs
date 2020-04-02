using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba_4
{
    public class Rows
    {
        private string raw;
        private int length;
        private void Initualiz()//Ініціалізація за умовчанням
        {
            raw = "";
            length = 0;
        }
        public Rows()//Конструктор за умовчанням
        {
            Initualiz();
        }
        public void Str_len(string str)//Для знаходження довжини рядка
        {
            this.length = str.Length;
        }

        public Rows(string str)//Конструктор з параметрами
        {
            this.raw = str;
            Str_len(str);
        }
        public Rows(Rows kot)//Конструктор копіювання
        {
            this.raw = kot.raw;
            this.length = kot.raw.Length;
        }
        
        public string Return_Str()//Для повернення рядка
        {
            return this.raw;
        }
        public static Rows operator +(Rows left_ward, Rows right_ward)//Оператор додавання двох рядків
        {
            Rows rezult = new Rows();
            rezult.raw = left_ward.raw + right_ward.raw;
            return rezult;
        }
        public static Rows operator *(Rows kot,int a)//Оператор множення 
        {
            string nut = "";
            for(int i = 0; i < kot.length; i++) 
            { 
               for(int j = 0; j < a; j++)
                    nut += kot.raw[i];
            }
            kot.raw = nut;
            return kot;
        }
    }
}