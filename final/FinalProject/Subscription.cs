using System;

// Base class
public class Subscription
{
    protected double basePrice; //price of the subscription package 
    protected int duration;  //duration of the subscription package
    protected double taxRate = 0.1; //the tax rate

    public Subscription(double basePrice, int duration) // constructor
    {
        this.basePrice = basePrice;
        this.duration = duration;
    }
    public virtual void Display() // virtual key word to calculate the subscription package to it can be change in other class.
    {
        Console.WriteLine("Subscrition details: ");
        Console.WriteLine($"- Base price: ${basePrice:F2}");
        Console.WriteLine($"- Duration: {duration} days");
        Console.WriteLine($"- Tax rate: {taxRate:P2}");
    }
    public double CalculatePrice() //method to calculate the subscription package.
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