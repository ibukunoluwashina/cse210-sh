using System;

// Base class
public class Subscription
{
    protected double basePrice;
    protected int duration;
    protected double taxRate = 0.1;

    public Subscription(double basePrice, int duration)
    {
        this.basePrice = basePrice;
        this.duration = duration;
    }
    public virtual void Display()
    {
        Console.WriteLine("Subscrition details: ");
        Console.WriteLine($"- Base price: ${basePrice:F2}");
        Console.WriteLine($"- Duration: {duration} days");
        Console.WriteLine($"- Tax rate: {taxRate:P2}");
    }
    public double CalculatePrice()
    {
        double totalPrice = basePrice * duration;
        double tax = totalPrice * taxRate;
        return totalPrice + tax;
    }

    public static implicit operator Subscription(string v)
    {
        throw new NotImplementedException();
    }
}