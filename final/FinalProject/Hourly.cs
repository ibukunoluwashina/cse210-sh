using System;

//Hourly class - inherits from Subscription class
public class Hourly : Subscription
    {
        public Hourly(double basePrice, int duration) : base(basePrice, duration)
        {
            taxRate = 0.05;
        }
        
        public override void Display()
        {
            Console.WriteLine("Hourly subscription details: ");
            base.Display();
        }
    }
