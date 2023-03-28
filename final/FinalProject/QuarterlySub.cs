using System;

//Quarterly class - inherits from the base class(subscription)
public class Quarterly : Subscription
    {
        public Quarterly(double basePrice, int duration) : base(basePrice, duration)
        {
            taxRate = 0.06;
        }

        public override void Display() //this used the priciple of polymorphism to display the Quarterly subscription.
        {
            Console.WriteLine("Quarterly subscription details: ");
            base.Display();
        }
    }