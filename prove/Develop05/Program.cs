using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = LoadGoals();
while (true)
        {
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Show list of goals");
            Console.WriteLine("4. Show user's score");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the type of goal (1 for SimpleGoal, 2 for EternalGoal):");
                    int goalType = int.Parse(Console.ReadLine());
                    Goal goal;
                    if (goalType == 1)
                    {
                        Console.WriteLine("Enter the name of the simple goal:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the point value of the simple goal:");
                        int points = int.Parse(Console.ReadLine());
                        goal = new SimpleGoal(name, points);
                    }
                    else if (goalType == 2)
                    {
                        Console.WriteLine("Enter the name of the eternal goal:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the point value of the eternal goal:");
                        int points = int.Parse(Console.ReadLine());
                        goal = new EternalGoal(name, points);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type");
                        continue;
                    }
                    goals.Add(goal);
                    SaveGoals(goals);
                    Console.WriteLine("Goal created successfully");
                    break;
                case 2:
                    Console.WriteLine("Enter the number of the goal you want to record an event for:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].Name}");
                    }
                    int goalNumber = int.Parse(Console.ReadLine()) - 1;
                    goals[goalNumber].RecordEvent();
                    SaveGoals(goals);
                    Console.WriteLine("Event recorded successfully");
                    break;
                case 3:
                    Console.WriteLine("List of goals:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        string status = goals[i].IsComplete() ? "[x]" : "[ ]";
                        string progress = "";
                        if (goals[i] is SimpleGoal)
                        {
                            SimpleGoal simpleGoal = (SimpleGoal)goals[i];
                            progress = $"completed {simpleGoal.TimesCompleted}/{simpleGoal.RequiredTimes} times";
                        }
                        Console.WriteLine($"{status} {goals[i].Name} ({goals[i].PointValue} points) {progress}");
                    }
                    break;
                case 4:
                    int score = 0;
                    foreach (Goal g in goals)
                    {
                        score += g.Score;
                    }
                    Console.WriteLine($"Your score is {score} points");
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static List<Goal> LoadGoals()
    {
        if (!File.Exists("goals.json"))
        {
            return new List<Goal>();
        }
        string json = File.ReadAllText("goals.json");
        return JsonSerializer.Deserialize<List<Goal>>(json);
    }

    static void SaveGoals(List<Goal> goals)
    {
        string json = JsonSerializer.Serialize(goals);
        File.WriteAllText("goals.json", json);
    }
}
