using System;

//Hourly class - inherits from the base class (subscription)
public class Hourly : Subscription
    {
        public Hourly(double basePrice, int duration) : base(basePrice, duration)
        {
            taxRate = 0.05;
        }
        
        public override void Display() //this used the priciple of polymorphism to display the hourly subscription.
        {
            Console.WriteLine("Hourly subscription details: ");
            base.Display();
        }
    }
