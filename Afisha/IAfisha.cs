using System;
using System.Collections.Generic;
namespace Afisha
{
    public interface IAfisha
    {
        public List<IPerfomance> SearchByAuthor(string author);
        public List<IPerfomance> SearchByName(string name);
        public List<IPerfomance> SearchByGenre(string genre);
        public List<IPerfomance> SearchByDate(long date);
        public List<IPerfomance> SearchByTicketsAvailable();
        public List<IPerfomance> SearchByTicketsPrice(int price);
    }
}
