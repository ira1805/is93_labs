using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_forMainProgram
{
    public class Class1
    {
        private int length;// довжина
        private string str;//  рядок
        public Class1()//Конструктор за замовчунням
        {
            Init();
        }
        public Class1(string str)//Конструктор з параметрами
        {
            this.str = str;
            LENGTH(str);
        }
        public Class1(Class1 p)//Конструктор копіювання
        {
            this.str = p.str;
            this.length = p.str.Length;
        }
        public void LENGTH(string str)//Метод для знаходження довжини рядка
        {
            this.length = str.Length;
        }
        private void Init()//Ініціалізація за замовченням
        {
            str = "";
            length = 0;
        }
        public string GetStr()//Метод для повернення рядка
        {
            return this.str;
        }
        public static Class1 operator +(Class1 left_val,Class1 right_v)//Оператор для додавання двох рядків
        {
            Class1 rez = new Class1();
            if (right_v.str.Length==0 ||left_val.str.Length==0||right_v.str==null || left_val.str==null)
            {
                throw new ArgumentNullException("String has got null value!!!");
            }
            rez.str = left_val.str + right_v.str;
            return rez;
        }
        public static Class1 operator /(Class1 op,int b)//Оператор для ділення рядка
        {
            string s="";
            if(b==0)
            {
                throw new ArgumentNullException("We have got null in the denominator!!!");
            }
            if(op.str.Length==0 || op.str==null)
            {
                throw new ArgumentNullException("String has got null value!!!");
            }
            for(int i=0;i<op.length;i++)
            {
                if(i%b==0)
                {
                    s += op.str[i];
                }
            }
            op.str = s;
            return op;
        }
    }
}
