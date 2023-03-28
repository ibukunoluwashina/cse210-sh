using System;

//Daily class - inherits from the base class(subscription)
public class Daily : Subscription
    {
        public Daily(double basePrice, int duration) : base(basePrice, duration)
        {
            taxRate = 0.08;
        }
        public override void Display() //this used the priciple of polymorphism to display the daily subscription.
        {
            Console.WriteLine("Daily subscription details: ");  
            base.Display();
        }
    }
