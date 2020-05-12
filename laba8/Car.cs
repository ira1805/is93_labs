using System;
using System.Timers;

namespace CarNamespace
{
    class Car
    {
        private int fuel;   //fuel variable
        public static System.Timers.Timer aTimer;   //timer
        public delegate void checkDel();    //delegate for event
        public event checkDel check;    //init event

        public Car()    //default constructor
        {
            fuel = 5;
            Console.WriteLine("car was created with 5 units of fuel");
        }

        public Car(int f)   //constructor with parameter
        {
            fuel = f;
            Console.WriteLine("car was created with " + fuel + " units of fuel");
        }

        public void AddFuel(int f)  //method to add fuel
        {
            fuel += f;
            Console.WriteLine("added " + f + " units of fuel");
        }

        public void Go()    //method to start going
        {
            if (fuel != 0)
            {
                Console.WriteLine("car has started with " + fuel + " units of fuel");
                SetTimer(); //set timer settings
                aTimer.Start(); //start timer
            }
        }

        public void Stop()  //method to stop the car
        {
            aTimer.Stop();  //stop timer
            Console.WriteLine("car's stopped");
        }

        public void SetTimer()  //timer settings
        {
            aTimer = new System.Timers.Timer(1000); //init timer with interval
            aTimer.Elapsed += OnTimedEvent; //add timer event listener
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e) //event listener method
        {
            fuel--; //decrease fuel
            check();    //check if there's any fuel
            if (fuel != 0)  //if car has some fuel
                Console.WriteLine("car's riding, left " + fuel + " units of fuel");
        }

        public void CheckFuel() //event listener, fuel checking method
        {
            if (fuel == 0)
                NoFuel();   //call method to say that car's run out of fuel
        }

        public static void NoFuel() //car's run out of fuel method
        {
            aTimer.Stop();  //stop timer
            Console.WriteLine("car's run out of fuel and stopped");
        }
    }
}
