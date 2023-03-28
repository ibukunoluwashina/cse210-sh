using System;

//Yearly class - inherits from the base class(subscription)
public class Annual : Subscription
    {
        public Annual(double basePrice, int duration) : base(basePrice, duration)
        {
            taxRate = 0.03;
        }

        public override void Display()   //this used the priciple of polymorphism to display the yearly subscription.
        {
            Console.WriteLine("Annual subscription details: ");
            base.Display();
        }
    }