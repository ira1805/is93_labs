using System;

namespace Lab3
{
    class Program
    {     
        static void Main(string[] args)
        {
            var studentsTable = new StudentsTable(size: 5);
            var student1 = new Student()
            {
                FirstName = "Ivan",
                LastName = "Sidorov",
                MiddleName = "Petovych"
            };
            var student2 = new Student()
            {
                FirstName = "Polina",
                LastName = "Sidenko",
                MiddleName = "Yurivna"
            };
            var student3 = new Student()
            {
                FirstName = "Maxim",
                LastName = "Ivanov",
                MiddleName = "Andrievich"
            };
            studentsTable[0] = student1;
            studentsTable[1] = student2;
            studentsTable[2] = student3;
            Console.WriteLine("Student's Table: ");
            Console.WriteLine(studentsTable[0].GetFullName());
            Console.WriteLine(studentsTable[1].GetFullName());
            Console.WriteLine(studentsTable[2].GetFullName());

            studentsTable[1].FirstName = "Dasha";        //change first name for second student
            Console.WriteLine("Changed student's Table: ");
            Console.WriteLine(studentsTable[0].GetFullName());
            Console.WriteLine(studentsTable[1].GetFullName());
            Console.WriteLine(studentsTable[2].GetFullName());
            Console.ReadKey();
        }
    }
}
