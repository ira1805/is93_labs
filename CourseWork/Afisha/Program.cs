using System;
using System.Collections.Generic;

namespace Afisha
{
    class Program
    { 
        static Afisha afisha;
        
        static List<ITicket> boughtTickets = new List<ITicket>();   //Створюємо ячейку в пам'яті
        static List<ITicket> bookedTickets = new List<ITicket>();   //Створюємо ячейку в пам'яті

        public static void ShowMenu()   //Меню програми
        { 
            Console.WriteLine("Щоб перейти до перегляду вистав , введіть 1");
            Console.WriteLine("Щоб здійснити пошук по автору , введіть 2");
            Console.WriteLine("Щоб здійснити пошук по назві вистави , введіть 3");
            Console.WriteLine("Щоб здійснити пошук по жанру , введіть 4");
            Console.WriteLine("Щоб здійснити пошук по даті , введіть 5");
            Console.WriteLine("Щоб здійснити пошук по доступним квиткам , введіть 6");
            Console.WriteLine("Щоб здійснити пошук по ціні квитка , введіть 7");
            Console.WriteLine("Щоб придбати білет , введіть 8");
            Console.WriteLine("Щоб придбати заброньований білет , введіть 9");
            Console.WriteLine("Щоб забронювати білет , введіть 10");
            Console.WriteLine("Щоб зупинити програму введіть 11");
        }

        public static void ReactToInput(string input)   //Реакція на введені дані
        {
            
            if (input == "1")
            {
                afisha.PrintPerfomance();
   
            }

            if (input == "2")
            {
                Console.WriteLine("Введіть автора");

                string writeAuthor = Console.ReadLine();

                List<IPerfomance> perfomances = afisha.SearchByAuthor(writeAuthor);

                for (int i = 0; i < perfomances.Count; ++i)
                {
                    Console.WriteLine(perfomances[i]);
                }

                
            }

            if (input == "3")
            {
                Console.WriteLine("Введіть назву вистави");

                string writePerfomance = Console.ReadLine();

                List<IPerfomance> perfomances = afisha.SearchByName(writePerfomance);

                for(int i = 0; i < perfomances.Count; ++i)
                {
                    Console.WriteLine(perfomances[i]);
                }
            }

            if (input == "4")
            {
                Console.WriteLine("Введіть жанр");

                string writeGenre = Console.ReadLine();

                List<IPerfomance> perfomances = afisha.SearchByGenre(writeGenre);

                for (int i = 0; i < perfomances.Count; ++i)
                {
                    Console.WriteLine(perfomances[i]);
                }
            }

            if (input == "5")
            {
                Console.WriteLine("Введіть дату");

                long writeDate = Convert.ToInt32(Console.ReadLine());

                List<IPerfomance> perfomances = afisha.SearchByDate(writeDate);

                for (int i = 0; i < perfomances.Count; ++i)
                {
                    Console.WriteLine(perfomances[i]);
                }
            }

            if (input == "6")
            {
                Console.WriteLine("Доступні квитки");

                List<IPerfomance> perfomances = afisha.SearchByTicketsAvailable();

                for (int i = 0; i < perfomances.Count; ++i)
                {
                    Console.WriteLine(perfomances[i]);
                }
            }
            
            if (input == "7")
            {
                Console.WriteLine("Введіть ціну білета");

                int writePrice = Convert.ToInt32(Console.ReadLine());

                List<IPerfomance> perfomances = afisha.SearchByTicketsPrice(writePrice);

                for (int i = 0; i < perfomances.Count; ++i)
                {
                    Console.WriteLine(perfomances[i]);
                }
            }

            if (input == "8")
            {
                Console.WriteLine("Введіть назву вистави");
                
                string perfomanceNameInput = Console.ReadLine();

                List<IPerfomance> perfomances = afisha.SearchByName(perfomanceNameInput);

                
                if (perfomances.Count == 0)
                {
                    Console.WriteLine("Таких вистав не існує");
                    return;
                }

                Console.WriteLine("Введіть 0 щоб купити білет в партер");
                Console.WriteLine("Введіть 1 щоб купити білет на балкон");
                Console.WriteLine("Введіть 2 щоб купити білет в бенуар");      

                TicketPlace ticketPlace = (TicketPlace)Convert.ToInt32(Console.ReadLine());

                ITicket boughtTicket = perfomances[0].BuyTicket(ticketPlace);

                if(boughtTicket == null)
                {
                    Console.WriteLine("Білетів на зазначене місце немає");
                    return;
                }

                boughtTickets.Add(boughtTicket);

                Console.WriteLine("Білет куплено");
                

            }

            if (input == "9")
            {
                Console.WriteLine("Введіть назву вистави");

                string perfomanceNameInput = Console.ReadLine();

                
                Console.WriteLine("Введіть місце(0 - партер, 1 - балкон, 2 - бенуар)"); 

                TicketPlace ticketPlace = (TicketPlace)Convert.ToInt32(Console.ReadLine());

                ITicket ticket = null;

               

                for (int i = 0; i < bookedTickets.Count; ++i)
                {
                    if(bookedTickets[i].PerfomanceName == perfomanceNameInput && bookedTickets[i].TicketPlace == ticketPlace)
                    {
                        ticket = bookedTickets[i];
                    }
                }

                if (ticket == null)
                {
                    Console.WriteLine("Таких білетів немає");
                    return;
                }

                List<IPerfomance> perfomances = afisha.SearchByName(perfomanceNameInput);


                if (perfomances.Count == 0)
                {
                    Console.WriteLine("Таких вистав не існує");
                    return;
                }

                perfomances[0].BuyTicket(ticket);

                bookedTickets.Remove(ticket);
                boughtTickets.Add(ticket);

                Console.WriteLine("Заброньований білет куплено");
            }

            if (input == "10")
            {
                Console.WriteLine("Введіть назву вистави");

                string perfomanceNameInput = Console.ReadLine();

                List<IPerfomance> perfomances = afisha.SearchByName(perfomanceNameInput);

                if (perfomances.Count == 0)
                {
                    Console.WriteLine("Таких вистав не існує");
                    return;
                }

                Console.WriteLine("Введіть місце(0 - партер, 1 - балкон, 2 - бенуар)");

                TicketPlace ticketPlace = (TicketPlace)Convert.ToInt32(Console.ReadLine());

                ITicket ticket = perfomances[0].BookTicket(ticketPlace);

                if (ticket == null)
                {
                    Console.WriteLine("Таких білетів немає");
                }

                bookedTickets.Add(ticket);
                Console.WriteLine("Білет заброньовано");
            }
        }

        static void Main(string[] args)
        {
            afisha = new Afisha();  //Ініціалізація Афіши

            Utils.GeneratePerfomances(afisha);  //Генеруємо вистави

            while (true)
            {
                ShowMenu();
                string input = Console.ReadLine();
                if (input == "11")
                {
                    break;
                }
                ReactToInput(input);
            }
        }
    }
}
