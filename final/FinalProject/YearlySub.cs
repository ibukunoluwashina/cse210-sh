using System;

public class Annual : Subscription
    {
        public Annual(double basePrice, int duration) : base(basePrice, duration)
        {
            taxRate = 0.03;
        }

        public override void Display()
        {
            Console.WriteLine("Annual subscription details: ");
            base.Display();
        }
    }