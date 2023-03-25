using System;

public class Quarterly : Subscription
    {
        public Quarterly(double basePrice, int duration) : base(basePrice, duration)
        {
            taxRate = 0.06;
        }

        public override void Display()
        {
            Console.WriteLine("Quarterly subscription details: ");
            base.Display();
        }
    }