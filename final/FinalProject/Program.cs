using System;
using System.Globalization;

class Program
{
    private static int choice;
    private static NumberStyles s;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tele Cable subscription service");
        Console.WriteLine("Please select a subscription package:");

    //Prompt the user to select a subscription package.
        Console.WriteLine("1. Hourly");
        Console.WriteLine("2. Daily");
        Console.WriteLine("3. Weekly");
        Console.WriteLine("4. Monthly");
        Console.WriteLine("5. Quarterly");
        Console.WriteLine("6. Biannual");
        Console.WriteLine("7. Annual");

        int choice = 0;
        
        int.Parse(Console.ReadLine());

        //Get the base price and duration base on user choice
        Subscription subscription;

        switch (choice)
        {
            case 1:
                subscription = new Hourly(10, 24);
                break;

            case 2:
                subscription = new Daily(20, 30);
                break;

            case 3: 
                subscription = new Weekly(30, 60);
                break;

            case 4:
                subscription = new Monthly(50, 90);
                break;

            case 5:
                subscription = new Quarterly(80, 180);
                break;

            case 6:
                subscription = new Biannual(150, 365);
                break;

            case 7:
                subscription = new Annual(250, 365);
                break;

            default: 
                Console.WriteLine("Invalid choice. Please try again.");
                return;
        }
        Console.WriteLine();
        subscription.Display();

        double price = subscription.CalculatePrice();
        Console.WriteLine($"Total price: ${price: F2}");
    }
}