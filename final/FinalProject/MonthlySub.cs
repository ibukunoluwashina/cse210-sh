using System;

public class Monthly : Subscription
{
    public Monthly(double basePrice, int duration) : base(basePrice, duration)
    {
        taxRate = 0.07;
    }

    public override void Display()
    {
        Console.WriteLine("Monthly subscription details: ");
        base.Display();
    }
} 