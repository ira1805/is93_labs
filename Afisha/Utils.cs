using System;
namespace Afisha
{
    public class Utils
    {
        public static DateTime UnixTimeToDateTime(long unixtime) //Переведение время с 1970 года в файле
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        public static void GeneratePerfomances(Afisha afisha)       //Генерування вистав
        {
            afisha.CreatePerfomance("Чехов",
                                    "Чайка",
                                    "Драма",
                                    new TicketQuantity() { balcony = 3, parter = 5, side = 7 },
                                    new TicketPrice() { priceParter = 13, priceBalcony = 14, priceSide = 1 },
                                    1591266337);

            afisha.CreatePerfomance("Чайковський",
                                    "Лебедине Озеро",
                                    "Балет",
                                    new TicketQuantity() { balcony = 2, parter = 3, side = 4 },
                                    new TicketPrice() { priceParter = 12, priceBalcony = 14, priceSide = 1 },
                                    1591266336);
        }

        public Utils()
        {

        }
    }
}
