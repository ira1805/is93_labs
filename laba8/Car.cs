using System;
using System.Timers;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Collections.Specialized;

namespace CarNamespace
{
    class MyEvent : EventArgs
    {
        public MyEvent()
        {
            Console.WriteLine("event");
        }
    }

    class Car
    {
        private int odo;   // пробіг
        public static System.Timers.Timer timer;   // таймер
        public event EventHandler<MyEvent> Checkodo;     // подія
        public delegate void MyDelegate(object sender, MyEvent ea);    // делегат для події


        public Car()    // конструктор за змовчуванням
        {
            odo = 0;
            Console.WriteLine("Ви придбали нову машину! Пробіг = 0 м");
        }

        public Car(int o)   // конструктор з параметрами
        {
            odo = o;
            Console.WriteLine("Ви придбали б/у машину. Пробіг = " + odo + " м");
        }

        public int Odometr()  // обчислення пробігу
        {
            return odo;
        }

        public void Drive()    // початок руху та рух
        {
            Console.WriteLine("машина поїхала. пробіг = " + odo + " м");
            if (odo <= 10)
            {
                timer = new System.Timers.Timer(1000);
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = true;
                timer.Enabled = true;
                timer.Start();
            }
        }

        public void OnTimedEvent(object sender, ElapsedEventArgs e) 
        {
            odo++;
            Console.WriteLine("машина їде. пробіг = " + odo + " м");
            Checkodo = CheckOdometr;
            MyEvent ea = new MyEvent();
            Checkodo(this, ea);
        }

        public void Stop()  
        {
            timer.Stop(); 
            timer.Close();
            Console.WriteLine("машина зупинилась");
        }

        public void CheckOdometr(object sender, MyEvent ea)
        {
            if (odo > 10)
            {
                timer.Stop();  
                Console.WriteLine("машина проїхала " + odo + " м і зламалась");
            }
        }
    }
}