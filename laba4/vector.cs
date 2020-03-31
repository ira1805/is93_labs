using System;
using System.Collections.Generic;
using System.Text;

namespace vector
{
    class VectorPol
    {
        private List<double> m_data;

        public VectorPol()     //конструктор за умовчуванням
        {
            m_data = new List<double>();
            m_data.Add(0);
            m_data.Add(0);
        }

        public VectorPol(double rad, double ang)    //конструктор з параметрами
        {
            m_data = new List<double>();
            m_data.Add(rad);
            m_data.Add(ang);
        }

        public VectorPol(VectorPol em_data) //конструктор копіювання
        {
            m_data = new List<double>();
            m_data.Add(em_data.m_data[0]);
            m_data.Add(em_data.m_data[1]);
        }

        public void Rotate(double angle)   //метод повороту на кут
        { 
            m_data[1] += angle;
        }

        public double GetRad() //метод зчитування довжини
        {  
            return m_data[0];
        }

        public double GetAng() //метод зчитування кута
        {   
            return m_data[1];
        }

        public static VectorPol operator/(VectorPol v, double x)    //перегрузка оператора ділення
        {   
            return new VectorPol(v.m_data[0] / x, v.m_data[1]);
        }

        public static VectorPol operator+(VectorPol v1, VectorPol v2) //перегрузка оператора додавання
        {   
            return new VectorPol(v1.m_data[0] + v2.m_data[0], v1.m_data[1] + v2.m_data[1]);
        }

        public override string ToString() //перегрузка методу для виведення вмісту класа
        {
            return "radius: " + m_data[0].ToString() + "\n angle: " + m_data[1].ToString() + "\n\n";
        }
    }
}
