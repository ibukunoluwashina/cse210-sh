using System;


public class ListingActivity : activity
{
    public ListingActivity(string _name, string _number, string _time, string _question) : base(_name, _number, _time)
    {
    }

    public ListingActivity(string name, string number, int time) : base(name, number, time)
    {
    }

    private List<string> _ListOfQuestions = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int rdindex;

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int rdIndex = rnd.Next(_ListOfQuestions.Count);
        Thread.Sleep(1000);
        string question = _ListOfQuestions[rdindex];
        return question;
    }

    public void DisplayQuestion()
    {
        Console.WriteLine("List as many response as you can to do the following prompt:");
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