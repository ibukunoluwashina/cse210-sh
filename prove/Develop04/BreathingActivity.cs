using System;

public class BreathingActivity : activity
{
    private static string _time;


    public BreathingActivity(string _name, string _number, int time) : base(_name, _number, _time)
    {
    }
    public void RunActivity()
            {
                DisplayStartingMessage();
                DisplayMessage();
                DisplayEndingMessage();
                SaveActivity();

            }
    public void DisplayMessage()
    {
        double time = GetTime();
        int res = Convert.ToInt32(time);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;

        if (!(res % 10 == 0))
        {
            int nbr = res % 10;
            if (nbr %2 == 0)
            {
                Console.Write("\nBreathe in....");
                PauseCountdownShown(nbr / 2);
                Console.Write("\nBreathe out...");
                PauseCountdownShown(nbr / 2);
                Console.WriteLine("");
                currentTime = DateTime.Now;
            }
            else
            {
                Console.Write("\nBreathe in...");
                PauseCountdownShown(5);
                Console.Write("\nBreathe out...");
                PauseCountdownShown(5);
                Console.WriteLine("");
                currentTime = DateTime.Now;
            }

            


        }
    }

    private void SaveActivity()
    {
    }

    private void DisplayEndingMessage()
    {
        throw new NotImplementedException();
    }

    private void DisplayStartingMessage()
    {
        throw new NotImplementedException();
    }

    private void PauseCountdownShown(int v)
    {
        throw new NotImplementedException();
    }

    private double GetTime()
    {
        throw new NotImplementedException();
    }
}
    