using System;

//Biannual class - inherits from the base class(subscription)
public class Biannual : Subscription
    {
        public Biannual(double basePrice, int duration) : base(basePrice, duration)
        {
            taxRate = 0.04;
        }

        public override void Display()   //this used the priciple of polymorphism to display the Biannual subscription.
        {
            Console.WriteLine("Biannual subscription details: ");
            base.Display();
        }
    }