using System;
using System.Collections.Generic;
namespace Afisha
{
    public interface ITicket
    {
        public void Reset();
        public void Book();
        public void Buy();
        
        public TicketPlace TicketPlace
        {
            get;
        }

        public TicketStatus TicketStatus
        {
            get;
        }

        public string PerfomanceName
        {
            get;
        }
    }
}
