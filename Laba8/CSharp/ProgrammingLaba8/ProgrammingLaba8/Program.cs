using System;
using System.Collections.Generic;

namespace ProgrammingLaba8
{
    enum DoctorsSpecialty//Doctors specializations
    {
        Pediatrics,
        Ophthalmology,
        Oncology,
        Dermatology,
        Gastroenterology
    }
    class Doctor
    {
        string name { get; set; }//Doctor's name
        string surname { get; set; }//Doctors's surname
        string patronymic { get; set; }//Doctor's patronymic(father's name)

        DoctorsSpecialty specialization;//Doctor's specialization(Oncology, Dermatology, etc.)

        Doctor(string name, string surname, string patronymic, DoctorsSpecialty specialization)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.specialization = specialization;
        }

        void availableAppointmentHours()
        {

        }
    }

    class Hospital
    {
        List<Doctor> staff = new List<Doctor>();//Hospital's staff list

        Hospital(List<Doctor> staff)
        {
            this.staff = staff;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
