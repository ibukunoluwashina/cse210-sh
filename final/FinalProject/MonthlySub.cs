using System;

//Monthly class - inherits from the base class(subscription)
public class Monthly : Subscription
{
    public Monthly(double basePrice, int duration) : base(basePrice, duration)
    {
        taxRate = 0.07;
    }

    public override void Display() //this used the priciple of polymorphism to display the weekly subscription.
    {
        Console.WriteLine("Monthly subscription details: ");
        base.Display();
    }
} 