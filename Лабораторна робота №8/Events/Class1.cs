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
        public List<object> list = new List<object>();//Make list of object
        public Class1(DelegateClear Event)//Make first construction
        {
            list = new List<object>();
            ClearEvent += Event;
        }
        public Class1(object s, DelegateClear Event)//Make second construction
        {
            if(s==null)
            {
                throw new ArgumentNullException("String has length of zero!");
            }
            list = new List<object>();//Initialization list
            list.Add(s);//Add first element
            list.Add(null);//Add second of null value
            ClearEvent += Event;//Add new event
        }
        public Class1(object s)//Make third construction
        {
            if (s == null)
            {
                throw new ArgumentNullException("String has length of zero!");
            }
            list = new List<object>();//Initialization list
            list.Add(s);//Add first element
            list.Add(null);//Add second of null value
        }
        public void AddNewElement(object s)//Method for adding new element in the line
        {
            if (s == null)
            {
                throw new ArgumentNullException("Element has a value of value`s null!!");
            }
            list[list.Count() - 1] = s;
            list.Add(null);
        }
        public void DeleteElement()//Delete first element in the line
        {
            if (list.Count() != 0)
            {
                list.RemoveAt(0);
                if (list.Count() == 1 && list[0] == null)
                {
                    list.RemoveAt(0);
                    ClearEvent();
                }
            }
            else
            {
                if (list.Count() == 0 && ClearEvent != null)
                {
                    ClearEvent();
                }
            }
        }
        public void RemoveAll()//Delete all element in the line
        {
            list.Clear();
            if(ClearEvent!=null)
            {
                ClearEvent();
            }
        }
    }
}
