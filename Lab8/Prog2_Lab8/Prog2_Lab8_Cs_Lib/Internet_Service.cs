using System;

namespace Prog2_Lab8_Cs_Lib
{

    public class Internet_Service
    {
        public string name;

        public Internet_Service(string name_in) { name = name_in; }

        // Класс делегату
        public delegate void IS_Event(object sender);

        // Список подій
        public event IS_Event Tariff_Choice = null;
        public event IS_Event Access_Granted = null;
        public event IS_Event Account_Refill = null;
        public event IS_Event Traffic_Exceeded = null;

        // Функція виклику події перевищення трафіку
        public virtual void On_Traffic_Exceeded()
        {
            if (Traffic_Exceeded != null)
            {
                Traffic_Exceeded(this);
            }
        }
    }
}
