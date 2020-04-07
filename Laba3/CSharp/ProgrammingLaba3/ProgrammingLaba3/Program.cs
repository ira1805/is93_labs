using System;
using System.Collections.Generic;

namespace ProgrammingLaba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shershun Maksim IS-93");

            List<Student> studentsList = new List<Student>();
            studentsList.Add(new Student("Maksim", "Shershun", "Miroslavovich"));
            studentsList.Add(new Student("Evgenii", "Nechai", "Viktorovich"));
            studentsList.Add(new Student("Andrei", "Kot", "Vasilovich"));
            studentsList.Add(new Student("Alex", "Samilenko", "Andriyovich"));
            studentsList.Add(new Student("Georg", "Nechai", "Maksimovich"));

            Table arr = new Table(studentsList);


            arr.add(new Student("Misha", "Storoguk", "Mukolayovich"));

            Console.WriteLine("Students Table:");
            Console.WriteLine();
            arr.show();
            Console.WriteLine();

            Console.WriteLine("Student with name Andrei:  " + arr["Andrei"].name + " " + arr["Andrei"].surname + " " + arr["Andrei"].fathersname + "Students with surname Nechai = " + arr.nechaiCounts);
    
        }
    }

    class Student
    {
        public string name;
        public string surname;
        public string fathersname;

        public Student() { }

        public Student(string name, string surname, string fathersname)
        {
            this.name = name;
            this.surname = surname;
            this.fathersname = fathersname;
        }
    };

    class Table
    {
        private List<Student> table;

        public Table() { }

        public Table(List<Student> students)
        {
            table = students;
        }

        public void add(Student student)
        {
            table.Add(student);
        }

        public void show()
        {
            foreach (Student i in table)
            {
                Console.WriteLine(i.name + " " + i.surname + " " + i.fathersname);
            }
        }

        public int nechaiCounts
        {
            get
            {
                int counter = 0;
                foreach (Student i in table)
                    if (i.surname == "Nechai")
                        counter += 1;
                return counter;
            }

        }

        public Student this[string name]
        {
            get
            {
                foreach (Student i in table)
                    if (i.name == name)
                        return i;
                return table[0];
            }
        }
    };

}
