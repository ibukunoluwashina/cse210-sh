using System;

// creat the class

public class activity
{
    // variable declarations so they can be re-used 2 reference
    private string _name;
    private string _number;
    private string _time;
    private string name;
    private string number;
    private int time;
    private string time1;

    public activity(string name, string number, int time)
    {
        this.name = name;
        this.number = number;
        this.time = time;
    }

    public activity(string name, string number, string time1)
    {
        this.name = name;
        this.number = number;
        this.time1 = time1;
    }

    public activity(string name, string _number, int v, int time)
    {
        this.name = name;
    }

    public activity(string _name, string _number, int v, string _time)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5000);
        Thread.Sleep(3000);
        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...");
        }
    }

    public void displayN(string name){
        Console.WriteLine(name);
    }
}