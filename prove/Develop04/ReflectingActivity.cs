using System;


public class ReflectingActivity : activity
{
    public ReflectingActivity(string _name, string _number, string _time, string _question) : base(_name, _number, _time)
    {
    }

    public ReflectingActivity(string name, string number, int time) : base(name, number, time)
    {
    }

    private List<string> _ListToPonder = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _ListOfQuestion = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private int rdindex;
    private object _ListOfQuestions;

    public string GetRandomPonder()
    {
        Random rnd = new Random();
        int rdIndex = rnd.Next(_ListToPonder.Count);
        Thread.Sleep(1000);
        string question = _ListToPonder[rdindex];
        return question;
    }
    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int rdIndex = rnd.Next(_ListOfQuestion.Count);
        Thread.Sleep(1000);
        string question = _ListOfQuestion[rdindex];
        return question;
    }
    public void DisplayPonder()
    {
        Console.WriteLine(GetRandomQuestion());
        Console.WriteLine("You may begin in: ");
        Console.WriteLine("");
    }

     public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
        Console.WriteLine("You may begin in: ");
        Console.WriteLine("");
    }

    private void PauseCountdownShow(int v)
    {
       PauseCountdownShow(5);
    }

    public void RunActivity()
    {
        
        DisplayQuestion();
        
        
    }

    private void DisplayEndingMessage()
    {
        DisplayEndingMessage();
    }

    private void DisplayStartingMessaga()
    {
        DisplayStartingMessaga();
    }

    private void SaveActivity()
    {
        SaveActivity();
    }
}