using System;
using System.Globalization;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to TeleCable TV subscription service");
        Console.WriteLine("Please select a subscription package:");

        //Prompt the user to select a subscription package.
        Console.WriteLine("1. Hourly");
        Console.WriteLine("2. Daily");
        Console.WriteLine("3. Weekly");
        Console.WriteLine("4. Monthly");
        Console.WriteLine("5. Quarterly");
        Console.WriteLine("6. Biannual");
        Console.WriteLine("7. Annual");

        int choice =

        int.Parse(Console.ReadLine());

        //Get the base price and duration base on user choice
        double basePrice = 0;
        int duration = 0;

        switch (choice)
        {
            case 1:
                basePrice = 10;
                duration = 24;
                break;

            case 2:
                basePrice = 60;
                duration = 24;
                break;

            case 3:
                basePrice = 150;
                duration = 14;
                break;

            case 4:
                basePrice = 250;
                duration = 30;
                break;

            case 5:
                basePrice = 600;
                duration = 90;
                break;

            case 6:
                basePrice = 1000;
                duration = 180;
                break;

            case 7:
                basePrice = 2000;
                duration = 365;
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return;
        }
        //subscription object based on user choice
        Subscription subscription = null;
        switch (choice)
        {
            case 1:
                subscription = new Hourly(basePrice, duration);
                break;

            case 2:
                subscription = new Daily(basePrice, duration);
                break;

            case 3:
                subscription = new Weekly(basePrice, duration);
                break;

            case 4:
                subscription = new Monthly(basePrice, duration);
                break;

            case 5:
                subscription = new Quarterly(basePrice, duration);
                break;

            case 6:
                subscription = new Biannual(basePrice, duration);
                break;

            case 7:
                subscription = new Annual(basePrice, duration);
                break;
        }

        //Display subscription details
        subscription.Display();

        //Calculate and display the price with tax

        double totalPrice = subscription.CalculatePrice();
        Console.WriteLine($"Total price(including tax): ${totalPrice:F2}");

        //prompt the user to subscribe and ask if they want auto renewer

        Console.WriteLine("Would you like to subscribe? (Y/N)");
        string subscribeChoice = Console.ReadLine();

        if (subscribeChoice.ToLower() == "y")
        {
            Console.WriteLine("Do you want enable auto renewer? (N/Y)");
            string autoRenewalChoice = Console.ReadLine();

            if (autoRenewalChoice.ToLower() == "y")
            {
                Console.WriteLine("Auto renewal is enable");
            }
            else
            {
                Console.WriteLine("Auto renewal is not enabled");
            }
        }
        else
        {
            Console.WriteLine("Thank you for using TeleCable TV service");
        }
    }
}
