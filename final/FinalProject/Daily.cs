using System;

//Hourly class - inherits from Subscription class
public class Daily : Subscription
    {
        public Daily(double basePrice, int duration) : base(basePrice, duration)
        {
            taxRate = 0.08;
        }
        public override void Display()
        {
            Console.WriteLine("Daily subscription details: ");
            base.Display();
        }
    }
