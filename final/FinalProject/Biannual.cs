using System;

public class Biannual : Subscription
    {
        public Biannual(double basePrice, int duration) : base(basePrice, duration)
        {
            taxRate = 0.04;
        }

        public override void Display()
        {
            Console.WriteLine("Biannual subscription details: ");
            base.Display();
        }
    }