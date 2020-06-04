using System;
using System.Collections.Generic;
namespace Afisha
{
    public class Perfomance : IPerfomance
    {
        private string _Author;             //Оголошення змінних 
        private string _Name;
        private string _Genre;
        private TicketQuantity _TicketQuantity;
        private List<ITicket> _Tickets;
        private TicketPrice _TicketPrice;
        private long _Date;

        public Perfomance(string author, string name, string genre, TicketQuantity ticketQuantity, TicketPrice ticketPrice, long date) //Ініціалізація змінних 
        {
            _Author = author;
            _Name = name;
            _Genre = genre;
            _TicketQuantity = ticketQuantity;
            _TicketPrice = ticketPrice;
            _Date = date;

            _Tickets = new List<ITicket>();
        
            GenerateTickets();   //Генеруємо білети кожен раз коли створюється вистава
        }

        public override string ToString()   //Перевантаження методу для перетворення об'єкту в рядок
        {
            return "Автор " + _Author
                + "\nІм'я "
                + _Name
                + "\nЖанр "
                + _Genre
                + "\nДата "
                + Utils.UnixTimeToDateTime(_Date)
                + "\nЦіни : "
                + _TicketPrice.ToString()
                + "\n"
                + _TicketQuantity.ToString();
   
        }
        
        public string Author
        {
            get { return _Author; }
            private set
            {
                _Author = value;
            }
        }

        public string Name
        {
            get { return _Name; }
            private set
            {
                _Name = value;
            }
        }

        public long Date
        {
            get { return _Date; }
            private set
            {
                _Date = value;
            }
        }

        public string Genre
        {
            get { return _Genre; }
            private set
            {
                _Genre = value;
            }
        }

        public TicketPrice TicketPrice
        {
            get { return _TicketPrice; }
            private set
            {
                _TicketPrice = value;
            }
        }


        private bool IsValid(ITicket ticket)    //Перевірка чи білет збігається з датою файла
        {
            return DateTime.Now.ToFileTime() < _Date;
        }

        private int GetPriceByTicketPlace(TicketPlace ticketPlace) //Отримуємо ціну білета залежачи від місця
        {
            int price = 0;

            switch (ticketPlace)
            {
                case TicketPlace.PARTER:
                    price = _TicketPrice.priceParter;
                    break;

                case TicketPlace.BALCONY:
                    price = _TicketPrice.priceBalcony;
                    break;

                case TicketPlace.SIDE:
                    price = _TicketPrice.priceSide;
                    break;
            }
            return price;
        }

        private void GenerateTickets()  //Генеруємо білети
        {
            GenerateTicketsOfSelectedType(_TicketQuantity.parter, TicketPlace.PARTER);
            GenerateTicketsOfSelectedType(_TicketQuantity.balcony, TicketPlace.BALCONY);
            GenerateTicketsOfSelectedType(_TicketQuantity.side, TicketPlace.SIDE);
        }

        private void GenerateTicketsOfSelectedType(int quantity, TicketPlace ticketPlace)   //Генеруємо білети
        {
            int price = GetPriceByTicketPlace(ticketPlace); 
            
            for (int i = 0; i < quantity; ++i)
            {
                _Tickets.Add(new Ticket(price, ticketPlace, _Date, _Name));
            }
        }

        public ITicket BuyTicket(ITicket ticket)    //Купивши білет міняємо статус на заброньований
        {
            if (IsValid(ticket) && ticket.TicketStatus == TicketStatus.BOOKED)
            {
                ticket.Buy();
            }
            return ticket;
        }


        public ITicket BuyTicket(TicketPlace ticketPlace)   //Купляємо білет по місцю
        {
            for (int i = 0; i < _Tickets.ToArray().Length; ++i)
            {
                if (ticketPlace == _Tickets[i].TicketPlace && _Tickets[i].TicketStatus == TicketStatus.AVAILABLE)
                {
                    _Tickets[i].Buy();
                    _Tickets.Remove(_Tickets[i]);
                    
                    return _Tickets[i];
                }
            }
            return null;
        }

        public ITicket BookTicket(TicketPlace ticketPlace)  //Бронюємо білет
        {
            for(int i = 0; i < _Tickets.ToArray().Length; ++i)
            {
                if(ticketPlace == _Tickets[i].TicketPlace && _Tickets[i].TicketStatus == TicketStatus.AVAILABLE)
                {
                    _Tickets[i].Book();
                    _Tickets.Remove(_Tickets[i]);

                    return _Tickets[i];
                }
            }
            return null;
        }

        public bool ReturnTicket(ITicket ticket)    //Повертаємо білет
        {
           if(IsValid(ticket))
           {
                ticket.Reset();
                _Tickets.Add(ticket);
                return true;
           }
            return false;
        }

        public bool TicketsAvailable(TicketPlace ticketPlace = TicketPlace.INVALID) //Доступні квитки
        {
            for(int i = 0; i < _Tickets.ToArray().Length; ++i)
            {
                if(_Tickets[i].TicketStatus == TicketStatus.AVAILABLE)
                {
                    if (ticketPlace == TicketPlace.INVALID)
                    {
                        return true;
                    }
                    if (ticketPlace == _Tickets[i].TicketPlace)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
