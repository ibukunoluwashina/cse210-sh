using System;

//Weekly class - inherits from the base class(subscription)
public class Weekly : Subscription
{
    public Weekly(double basePrice, int duration) : base(basePrice, duration)
    {
        taxRate = 0.09;
    }
    public override void Display()  //this used the priciple of polymorphism to display the weekly subscription.
    {
        Console.WriteLine("Weekly subscription details: ");
        base.Display();
    }
}