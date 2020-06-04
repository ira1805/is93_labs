using System;
using System.Collections.Generic;
namespace Afisha
{
    public class Afisha : IAfisha
    {
        private List<IPerfomance> _Perfomances; //Оголошення змінної вистави

        public Afisha()
        {
            _Perfomances = new List<IPerfomance>(); //Створюємо простір в пам'яті для списку вистав
        }

        public Afisha(List<IPerfomance> Perfomance) //Ініацілізуємо список вистав
        {
            _Perfomances = Perfomance;
        }

        private bool IsPerfomanceNameUnique(string name)    //Перевірка чи назва вистави не повторюється 
        {
            for(int i = 0; i < _Perfomances.Count; ++i)
            {
                if(_Perfomances[i].Name == name)
                {
                    return false;
                }
            }
            return true;
        }
        
        public void CreatePerfomance(string author, string name, string genre, TicketQuantity ticketQuantity, TicketPrice ticketPrice, long date) //Створюємо вистави
        {
            if (!IsPerfomanceNameUnique(name))
            {
                return;
            }
            
            _Perfomances.Add(new Perfomance(author, name, genre, ticketQuantity, ticketPrice, date));    
        }

        public void PrintPerfomance()   //Друкуємо список вистав
        {
            for(int i = 0; i < _Perfomances.ToArray().Length; ++i)
            {
                Console.WriteLine(_Perfomances[i].ToString());
            }
        }


        public List<IPerfomance> SearchByAuthor(string author)  //Здійснюємо пошук по автору
        {
            List<IPerfomance> result = new List<IPerfomance>();

            for (int i = 0; i < _Perfomances.ToArray().Length; ++i)
            { 
                if (author == _Perfomances[i].Author)
                {
                    result.Add(_Perfomances[i]);
                }
            }
            return result;
        }
        
        public List<IPerfomance> SearchByDate(long date)    //Здійснюємо пошук по даті
        {
            List<IPerfomance> result = new List<IPerfomance>();

            for (int i = 0; i < _Perfomances.ToArray().Length; ++i)
            {
                if (date == _Perfomances[i].Date)
                {
                    result.Add(_Perfomances[i]);
                }
            }
            return result;
        }

        public List<IPerfomance> SearchByGenre(string genre)    //Здійснюємо пошук по жанру
        {
            List<IPerfomance> result = new List<IPerfomance>();

            for (int i = 0; i < _Perfomances.ToArray().Length; ++i)
            {
                if (genre == _Perfomances[i].Genre)
                {
                    result.Add(_Perfomances[i]);
                }
            }
            return result;
        }

        public List<IPerfomance> SearchByName(string name)  //Здійснюємо пошук по назві вистави
        {
            List<IPerfomance> result = new List<IPerfomance>();

            for (int i = 0; i < _Perfomances.ToArray().Length; ++i)
            {
                if (name == _Perfomances[i].Name)
                {
                    result.Add(_Perfomances[i]);
                }
            }
            return result;
        }

        public List<IPerfomance> SearchByTicketsAvailable() //Здійснюємо пошук доступним білетам
        {
            List<IPerfomance> result = new List<IPerfomance>();

            for (int i = 0; i < _Perfomances.ToArray().Length; ++i)
            {
                if  (_Perfomances[i].TicketsAvailable())
                {
                    result.Add(_Perfomances[i]);
                }
            }
            return result;
        }

        public List<IPerfomance> SearchByTicketsPrice(int price)    //Здійснюємо пошук по ціні
        {
            List<IPerfomance> result = new List<IPerfomance>();

            for (int i = 0; i < _Perfomances.ToArray().Length; ++i)
            {
                if (price <= _Perfomances[i].TicketPrice.priceBalcony ||
                    price <= _Perfomances[i].TicketPrice.priceParter  ||
                    price <= _Perfomances[i].TicketPrice.priceSide)
                {
                    result.Add(_Perfomances[i]);
                }
            }
            return result;
        }
    }   
}
    