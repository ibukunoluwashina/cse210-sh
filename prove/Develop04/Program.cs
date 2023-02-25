using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        int time = 0;
        string breathing = "This activity will help you to relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.";
        string reflecting = "This activity will help you to reflect on times in your life when you have shown and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        string listing = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        BreathingActivity a1 = new BreathingActivity("Breathing Activity", breathing, time);
        ReflectingActivity a2 = new ReflectingActivity("Reflecting Activity", reflecting, time);
        ListingActivity a3 = new ListingActivity("Listing Activity", listing, time);

        do{
            Console.WriteLine("\nMenu Options: \n1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity");
            Console.WriteLine("Select a choice from the menu: ");

            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                a1.RunActivity();
            }
            else if (userChoice == "2")
            {
                a2.RunActivity();
            }
            else if (userChoice == "3")
            {
                a3.RunActivity();
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("Good Bye");
            }
            else 
            {
                Console.WriteLine("You have to choose between 1, 2, 3 or 4.");
            }
        } while (!(userChoice == "4"));
    }

}
