using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;
    static void Main(string[] args)
    {
        LoadData();

        while (true)
        {
            Console.WriteLine($"You have {score} points");
            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. View Goals");
            Console.WriteLine(" 2. Creat New Goal");
            Console.WriteLine(" 3. Record Event");
            Console.WriteLine(" 4. Save Goals and Exit");
            Console.WriteLine("Select a Choice from the menu list:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewGoals();
                    break;

                case 2:
                    AddGoal();
                    break;

                case 3:
                    RecordEvent();
                    break;

                case 4:
                    SaveData();
                    Console.WriteLine("Your progress has been saved. Goodbye");
                    return;

                default:
                    Console.WriteLine("invalid option. please try again");
                    break;
            }
        }
    }

    static void ViewGoals()
    {
        Console.WriteLine("Your goals:");
        foreach(Goal goal in goals)
        {
            Console.WriteLine($"{goal.Name} - {goal.GetProgress()} - {goal.PointValue} points");
        }
        Console.WriteLine($"Total score: {score} points");
    }
    static void AddGoal()
    {
        Console.WriteLine("What type of goal would you like to add?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("What type of goal would you like to creat?");
        string name = Console.ReadLine();

        Console.WriteLine("whats the amount of point associated with this goal?");
        int pointValue = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal(name, pointValue);
                goals.Add(simpleGoal);
                Console.WriteLine($"{name} has been added to a simple goal worth {pointValue} points.");
                break;

            case 2:
                EternalGoal eternalGoal = new EternalGoal(name, pointValue);
                goals.Add(eternalGoal);
                Console.WriteLine($"{name} has been added as an eternal goal worth {pointValue} points.");
                break;

            case 3:
                Console.WriteLine("How many times must you complete this goal?");
                int targetCount = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(name, pointValue, targetCount);
                goals.Add(checklistGoal);
                Console.WriteLine($"{name} has been added as a checklist goal worth {pointValue} points.");
                break;

            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
    static void RecordEvent()
    {
        Console.WriteLine("Which goal would you like to record an event for?");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        int choice = int.Parse(Console.ReadLine());

        if (choice <= goals.Count && choice > 0)
        {
            Goal chosenGoal = goals[choice - 1];
            chosenGoal.RecordEvent();
            score += chosenGoal.PointValue;
            Console.WriteLine($"{chosenGoal.Name} event recorded. you earned {chosenGoal.PointValue} points.");
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }
    }
    static void SaveData()
    {
        string json = JsonSerializer.Serialize(goals);
        File.WriteAllText("data.json", json);

        Console.WriteLine("Your progress has been saved. Goodbye");
    }
    static void LoadData()
    {
        if (File.Exists("data.json"))
        {
            string json = File.ReadAllText("data.json");
            goals = JsonSerializer.Deserialize<List<Goal>>(json);
            Console.WriteLine("Save data loaded. ");
        }
        else
        {
            Console.WriteLine("No save data found.");
        }
    }
}
