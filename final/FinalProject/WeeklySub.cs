using System;

public class Weekly : Subscription
{
    public Weekly(double basePrice, int duration) : base(basePrice, duration)
    {
        taxRate = 0.09;
    }
    public override void Display()
    {
        Console.WriteLine("Weekly subscription details: ");
        base.Display();
    }
}