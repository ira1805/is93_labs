using System;
using System.Collections.Generic;

namespace laba3
{
    class StudentsTable // Table with students
    {
        private List<List<string>> _table = new List<List<string>>(); // Empty table
        private List<string> _student;
        public string[] this[int index] // Create a student in the table
        {
            set
            {
                _student = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    _student.Add(value[i]);
                }

                try
                {
                    if (index == 0 || index == _table.Count) // Because we need to not only to change existing students but add new ones
                    {
                        _table.Add(_student);
                    }
                    else 
                    {
                        _table.RemoveAt(index);
                        _table.Insert(index, _student);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
        public int TableLength // Property with access to amount of students
        {
            get { return _table.Count; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IS-93 Kravchenko Olena, 12 variant");
            StudentsTable myTable = new StudentsTable();
            string[] student1 = {"FirstName", "Patronymic", "LastName"};
            string[] student2 = {"Alexander", "Sergeevich", "Pushkin"};
            string[] student3 = {"Ivan", "Ivanovich", "Ivanov"};
            myTable[0] = student1;
            myTable[0] = student2;
            myTable[1] = student3;
            Console.WriteLine("There are {0} students in the table", myTable.TableLength);
            myTable[3] = student3; // throw an error
        }
    }
}