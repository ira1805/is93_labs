using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events  
{
    public delegate void DelegateClear();
    public class Class1
    {
        public event DelegateClear ClearEvent;
        public List<object> list = new List<object>();// Составляем список объектов
        public Class1(DelegateClear Event)  // Сделать первую конструкцию
        {
            list = new List<object>();
            ClearEvent += Event;
        }
        public Class1() // Сделать первую конструкцию без события
        {
            list = new List<object>();
        }
        public Class1(object s, DelegateClear Event)// Сделать вторую конструкцию
        {
            if (s == null)
            {
                throw new ArgumentNullException("Your balance is zero!");
            }
            list = new List<object>();// Список инициализации
            list.Add(s);// Добавить первый элемент
            list.Add(null);// Добавить секунду нулевого значения
            ClearEvent += Event;// Добавить новое событие
        }
        public Class1(object s) // Сделать третью конструкцию

        {
            if (s == null)
            {
                throw new ArgumentNullException("Your balance is zero!");
            }
            list = new List<object>();// Список инициализации
            list.Add(s); // Добавить первый элемент
            list.Add(null);// Добавить секунду нулевого значения
        }
        public void AddNewElement(object s)// Метод добавления нового элемента в строку
        {
            if (s == null)
            {
                throw new ArgumentNullException("Element has a value of value`s null!!");
            }
      
            list.Add(null);
        }
        public void DeleteElement()// Удалить первый элемент в строке;
        {
            if (list.Count() != 0)
            {
                list.RemoveAt(0);
                if (list.Count() == 1 && list[0] == null)
                {
                    list.RemoveAt(0);
                    ClearEvent?.Invoke();// Если ClearEvent! = NULL -> ClearEvent ();
                }
            }
            else
            {
                ClearEvent?.Invoke();//еси ClearEvent !=NULL  ->  ClearEvent();
            }
        }
        public void RemoveAll()// Удалить все элементы в строке;
        {
            list.Clear();
            ClearEvent?.Invoke();//если ClearEvent !=NULL  ->  ClearEvent();
        }
    }
}
