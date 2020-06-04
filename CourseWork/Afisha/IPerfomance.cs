using System;
using System.Collections.Generic;

namespace Afisha
{
    public interface IPerfomance
    {
        public ITicket BuyTicket(TicketPlace ticketPlace);
        public ITicket BuyTicket(ITicket ticket);
        public ITicket BookTicket(TicketPlace ticketPlace);
        public bool ReturnTicket(ITicket ticket);
        public bool TicketsAvailable(TicketPlace ticketPlace = TicketPlace.INVALID);

        public string Author
        {
            get;
        }

        public string Name
        {
            get;
        }

        public long Date
        {
            get;
        }

        public string Genre
        {
            get;
        }

        public TicketPrice TicketPrice
        {
            get;
        }
    }
}
