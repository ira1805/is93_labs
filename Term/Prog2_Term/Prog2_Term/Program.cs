using System;
using System.Collections.Generic;
using Prog2_Term_Lib;

namespace Prog2_Term
{
    class Program
    {
        // Виведення команд реєстру на екран
        static void WriteComBase()
        {
            Console.WriteLine("Команди:");
            Console.WriteLine("1 - Список лiкарiв");
            Console.WriteLine("2 - Список пацiентiв");
            Console.WriteLine("3 - Додати доктора");
            Console.WriteLine("4 - Додати пацiєнта");
            Console.WriteLine("x - Вийти");
        }
        // Виведення команд лікаря на екран
        static void WriteComDoc()
        {
            Console.WriteLine("Команди:");
            Console.WriteLine("1 - Додати запис на прийом");
            Console.WriteLine("1 - Позначити прийом як пройдений");
            Console.WriteLine("x - Вийти");
        }
        // Обробник події, повідомляє про перетин прийомів
        static void EventHandler(object sender, int id)
        {
            Console.WriteLine("Помилка: Час обраний для прийому вже зайнятий прийомом номер "+id.ToString()+".");
            Console.ReadLine();
        }
        // Виведення списку лікарів реєстру на екран
        static void WriteOut(List<Doctor> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine(i.ToString() + " - " + input[i].Name);
            }
            return;
        }
        // Виведення списку хворих реєстру на екран
        static void WriteOut(List<Patient> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine(i.ToString() + " - " + input[i].Name);
            }
            return;
        }
        // Виведення списку запланованих прийомів лікаря на екран
        static void WriteOut(List<Doc_Visit> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine(i.ToString() + " - " + input[i].start.ToString() + " - " + input[i].end.ToString() + " - Пацiент: " + input[i].patient.Name);
            }
            return;
        }
        // Виведення списку пройдених хворим прийомів на екран
        static void WriteOut(List<Pat_Visit> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine(i.ToString() + " - " + input[i].start.ToString() + " - " + input[i].end.ToString() + " - Лiкар: " + input[i].doctor.Name + " - Дiагноз: " + input[i].diagnosis);
            }
            return;
        }

        static void Main(string[] args)
        {
            string input, start_in, end_in;
            int int_1, int_2;
            Console.WriteLine("Стеблянко Олександр, Курсова Робота, Варіант 9 \n");

            Registry Reg = new Registry();

            // Підписка обробника до глобальної події
            Reg.Appointment_Overlap_Global += new Medical_Event(EventHandler);

            // Створення початкових лікарів\хворих для демонстрації системи
            string[] names_doc = { "Сидоров", "Воронцов", "Свердлюк" };
            for (int i = 0; i < names_doc.Length; i++)
            {
                Reg.AddDoctor(names_doc[i]);
            }
            string[] names_pat = { "Говорун", "Голуб", "Розний" };
            for (int i = 0; i < names_pat.Length; i++)
            {
                Reg.AddPatient(names_pat[i]);
            }

            // Запис прийому до розкладу лікаря
            Reg.DocList[1].AddAppointment(Reg.PatList[1], "04/06/2020 11:00", "04/06/2020 11:20");

            // Інтерфейс користувача
            while (true)
            {
                WriteComBase();
                input = Console.ReadLine();
                switch (input)
                {
                    // Огляд списку лікарів
                    case "1": Console.WriteLine("Оберiть лiкаря для додаткової iнформацiї та дiй. Натиснiть х щоб вийти.");
                        WriteOut(Reg.DocList);
                        input = Console.ReadLine();
                        switch (input)
                        {
                            // Вихід зі списку
                            case "x": break;
                            // Вибір одного з лікарів
                            default: try { int.Parse(input); } catch { Console.WriteLine("Не цисло."); Console.ReadLine(); break; };
                                int_1 = int.Parse(input);
                                if (int_1 < Reg.DocList.Count && int_1 >= 0) 
                                {
                                    WriteComDoc();
                                    Console.WriteLine("Список записiв на прийом:");
                                    WriteOut(Reg.DocList[int_1].appointments);
                                    input = Console.ReadLine();
                                    switch (input)
                                    {
                                        // Запис на прийом до обраного лікаря
                                        case "1": Console.WriteLine("Оберіть пацiента:");
                                            WriteOut(Reg.PatList);
                                            input = Console.ReadLine();
                                            try { int.Parse(input); } catch { Console.WriteLine("Не цисло."); Console.ReadLine(); break; };
                                            int_2 = int.Parse(input);
                                            if (int_2 < Reg.PatList.Count && int_2 >= 0)
                                            {
                                                Console.WriteLine("Введіть очiкуваний час початку прийому в форматi День/Мiсаць/Рiк Година:Хвилина");
                                                start_in = Console.ReadLine();
                                                Console.WriteLine("Введiть очiкуваний час кiнця прийому в форматi День/Мiсаць/Рiк Година:Хвилина");
                                                end_in = Console.ReadLine();
                                                try { Reg.DocList[int_1].AddAppointment(Reg.PatList[int_2], start_in, end_in); } 
                                                catch { Console.WriteLine("Дати не відповідають формату."); Console.ReadLine(); }
                                            }
                                            break;
                                        // Помічення запису на прийом як виконаного, запис діагнозу
                                        case "2": Console.WriteLine("Оберiть запис:");
                                            WriteOut(Reg.DocList[int_1].appointments);
                                            input = Console.ReadLine();
                                            try { int.Parse(input); } catch { Console.WriteLine("Не цисло."); Console.ReadLine(); break; };
                                            int_2 = int.Parse(input);
                                            if (int_2 < Reg.DocList[int_1].appointments.Count && int_2 >= 0)
                                            {
                                                Console.WriteLine("Введiть дiагноз:");
                                                input = Console.ReadLine();
                                                Reg.DocList[int_1].CompleteAppointment(int_2, input);
                                            }
                                            break;
                                        // Жодна з опцій
                                        default: break;
                                    }
                                }
                                break;
                        }
                        break;

                    // Огляд списку хворих
                    case "2":
                        Console.WriteLine("Оберiть пацiента для додаткової iнформацiї. Натиснiть х щоб вийти.");
                        WriteOut(Reg.PatList);
                        input = Console.ReadLine();
                        switch (input)
                        {
                            // Вихід зі списку
                            case "x": break;
                            // Вибір одного з хворих
                            default:
                                try { int.Parse(input); } catch { Console.WriteLine("Не цисло."); Console.ReadLine(); break; };
                                int_1 = int.Parse(input);
                                if (int_1 < Reg.PatList.Count && int_1 >= 0) 
                                { 
                                    Console.WriteLine("Картка вiдвiдування:"); 
                                    WriteOut(Reg.PatList[int_1].history); 
                                    Console.ReadLine(); 
                                }
                                break;
                        }
                        break;

                    // Додання лікаря до реєстру
                    case "3": Console.WriteLine("Введiть iм'я доктора:");
                        input = Console.ReadLine();
                        Reg.AddDoctor(input);
                        break;

                    // Додання хворого до реєстру
                    case "4": Console.WriteLine("Введiть ім'я пацiента:");
                        input = Console.ReadLine();
                        Reg.AddPatient(input);
                        break;

                    // Вихід з системи
                    case "x": Environment.Exit(0); break;
                    // Жодна з опцій
                    default: break;
                }
                Console.Clear();
            }
        }
    }
}
