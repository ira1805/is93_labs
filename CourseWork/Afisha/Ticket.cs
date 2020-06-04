using System;
namespace Afisha
{
    public class Ticket : ITicket
    {
        private int _Price;                //Обьява змінних
        private TicketPlace _TicketPlace;
        private long _Date;
        private string _PerfomanceName;
        private TicketStatus _TicketStatus;

        public string PerfomanceName
        {
            get { return _PerfomanceName; }
        }

        public TicketPlace TicketPlace
        {
            get { return _TicketPlace; }
            private set
            {
                _TicketPlace = value;
            }
        }

        public TicketStatus TicketStatus
        {
            get { return _TicketStatus; }
            private set
            {
                _TicketStatus = value;
            }
        }

        public Ticket(int price, TicketPlace ticketPlace, long date, string perfomanceName)     //Ініціалізуємо самі дані білета 
        {
            _Price = price;
            _TicketPlace = ticketPlace;
            _Date = date;
            _PerfomanceName = perfomanceName;
            _TicketStatus = TicketStatus.AVAILABLE;
        }

        public void Book()              //В цьому методі змінюємо статус білета на заброньований
        {
            _TicketStatus = TicketStatus.BOOKED;
        }

        public void Buy()               //В цьому методі змінюємо статус білета на проданий
        {
            _TicketStatus = TicketStatus.SOLD;
        }
        
        public void Reset()             //В цьому методі змінюємо статус білета на в наявності
        {
            _TicketStatus = TicketStatus.AVAILABLE;
        }


    }
}
