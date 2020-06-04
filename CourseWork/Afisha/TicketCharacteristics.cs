using System;
namespace Afisha
{
    public struct TicketPrice
    {
                                       //public static int price;
        public int priceParter;
        public int priceBalcony;
        public int priceSide;

        public override string ToString()       //Перевантаження методу для перетворення об'єкту в рядок
        {
            return "Ціна для балкону " + priceBalcony + " Ціна для партеру " + priceParter + " Ціна для бенуару " + priceSide;
        }
    }

    public struct TicketQuantity        //Тип значення TicketQuantity
    {
        public int parter;
        public int balcony;
        public int side;

        public override string ToString()
        {
            return "Кількість місць на партер " + parter + " Кількість місць на балкон " + balcony + " Кількість місць на бенуар " + side;
        }
    }

    public enum TicketPlace : int   //Перечислення типу TicketPlace
    {
        INVALID = -1,
        PARTER = 0,
        BALCONY,
        SIDE
    }

    public enum TicketStatus : int  //Перечислення типу TicketStatus
    {
        INVALID = -1,
        BOOKED = 0,
        SOLD,
        AVAILABLE
    }
}
