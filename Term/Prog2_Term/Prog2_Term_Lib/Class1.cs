using System;
using System.Collections.Generic;
using System.Linq;

public delegate void Medical_Event(object sender, int id);

namespace Prog2_Term_Lib
{
    public class Visit
    {
        public DateTime start { get; protected set; }
        public DateTime end { get; protected set; }

        // Конструктор за string
        protected Visit(string start_in, string end_in)
        {
            start = DateTime.ParseExact(start_in, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            end = DateTime.ParseExact(end_in, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
        }
        // Конструктор за DateTime
        protected Visit(DateTime start_in, DateTime end_in)
        {
            start = start_in;
            end = end_in;
        }
    }
    public class Pat_Visit : Visit
    {
        public string diagnosis { get; protected set; }
        public Doctor doctor { get; protected set; }

        // Конструктор за string
        public Pat_Visit(string start_in, string end_in, string diag_in, Doctor doc_in) : base(start_in, end_in)
        {
            diagnosis = diag_in;
            doctor = doc_in;
        }
        // Конструктор за DateTime
        public Pat_Visit(DateTime start_in, DateTime end_in, string diag_in, Doctor doc_in) : base(start_in, end_in)
        {
            diagnosis = diag_in;
            doctor = doc_in;
        }
    }
    public class Doc_Visit : Visit
    {
        public Patient patient { get; protected set; }

        // Конструктор за string
        public Doc_Visit(string start_in, string end_in, Patient pat_in) : base(start_in, end_in)
        {
            patient = pat_in;
        }
        // Конструктор за DateTime 
        public Doc_Visit(DateTime start_in, DateTime end_in, Patient pat_in) : base(start_in, end_in)
        {
            patient = pat_in;
        }
    }

    public class Doctor
    {
        public string Name { get; protected set; }
        public List<Doc_Visit> appointments = new List<Doc_Visit>();

        // Конструктор
        public Doctor(string name_in) { Name = name_in; }

        // Локальна подія перетину записів на прийом
        public event Medical_Event Appointment_Overlap = null;

        // Додання прийому до розкладу
        public void AddAppointment(Patient pat, string start_in, string end_in) 
        {
            DateTime start = DateTime.ParseExact(start_in, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(end_in, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);

            for (int i = 0; i < appointments.Count; i++)
            {
                if (appointments[i].start < start && start < appointments[i].end) { Appointment_Overlap(this, i); return; }
                else if (appointments[i].start < end && end < appointments[i].end) { Appointment_Overlap(this, i); return; }
                else if (start < appointments[i].start && appointments[i].end < end) { Appointment_Overlap(this, i); return; }
            }
            appointments.Add(new Doc_Visit(start, end, pat));
        }

        // Завершення прийому
        public void CompleteAppointment(int index, string diagnosis)
        {
            appointments[index].patient.AddHistory(this, diagnosis, appointments[index]);
            appointments.RemoveAt(index);
        }
    }
    public class Patient
    {
        public string Name { get; protected set; }
        public List<Pat_Visit> history = new List<Pat_Visit>();

        // Конструктор
        public Patient(string name_in) { Name = name_in; }

        // Додання завершеного прийому до картки відвідування
        public void AddHistory(Doctor doc, string diagnosis, Doc_Visit visit)
        {
            history.Add(new Pat_Visit(visit.start, visit.end, diagnosis, doc));
        }
    }
    public class Registry
    {
        public List<Doctor> DocList = new List<Doctor>();
        public List<Patient> PatList = new List<Patient>();

        // Глобальна подія перетину записів на прийом
        public event Medical_Event Appointment_Overlap_Global = null;

        // Додання нового лікаря до реєстру
        public void AddDoctor(string name) 
        { 
            DocList.Add(new Doctor(name)); 
            DocList.Last().Appointment_Overlap += Appointment_Overlap_Global; 
        }
        // Додання нового хворого до реєстру
        public void AddPatient(string name) { PatList.Add(new Patient(name)); }
    }
}
