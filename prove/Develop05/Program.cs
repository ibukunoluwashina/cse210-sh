using System;

class Program
{
    static void Main(string[] args)
    {
        int action = 0;
        int points = 0;
        list<Goal> goals = new list<Goal>();

        while (action ! = 6)
        {
            Console.Writeline("");
            Console.Writeline($"You have {points} points");
            Console.Writeline("");
            Console.Writeline("Menu:");
            Console.Writeline("1) Creat New Goal");
            Console.Writeline("2) List Goals");
            Console.Writeline("3) Save Goals");
            Console.Writeline("4) Load Goals");
            COnsole.Writeline("5) Record Event");
            Console.Writeline("6) Quit");
            COnsole.Writeline("");

            Console.Writeline("What would you like to do?");
            action = Convert.ToInt32(Console.ReadLine());

            if(action ==1)
            {
                Console.Writeline("select the type of goal: ");
                Console.Writeline("1) Simple goal");
                Console.Writeline("2) Eternal goal");
                Console.Writeline("3) Checklist goal");
                Console.Writeline("");
                int goalType = Convert.ToInt32(Console.ReadLine());

                Console.Writeline("What is the goal? ");
                string name = (Console.Writeline());
                Console.Writeline("What is the goal about?: ");
                string description = (Console.ReadLine());

                if(goalType == 1){
                    SimpleGoal = new SimpleGoal(name, description);
                    goals.Add(goal);
                }

                else if(goalType == 2){
                    EternalGoal goal = new EternalGoal(name, description);
                    goals.Add(goal);
                }
                else
                {
                    Console.Writeline("How many times you want to do it? ");

                    int number = Convert.ToInt32(Console.Read());
                    ChecklistGoal goal = new ChecklistGoal(name, description, number);
                    goals.Add(goal);
                }

            }
            if(action == 2)
            {
        
                for(int i = 0; i < goals.Count; i++)
                {
                    goals[i].Display();
                }
            }
            if(action ==3)
            {
                File file = new File();
                file.Save(goals);
            }
            if(action == 4)
            {
            
            }
            if(action == 5)
            {
                Console.Writeline("Select the goal you want to record");

                for(int i = 0; i < goals.Count; i++)
                {
                    goals[i].Display();
                }

                int option = Convert.ToInt32(Console.ReadLine());
                option -=1;

                goals[option].RecordEvent();


                goals[option].Display();
            }

            if(action == 6)
            {
                break;
            }
        }
    }

}
