using System;

public class Entry 
{
    public string _date = "";
    public string _prompt = "";
    public string _userEntry = "";
    public Prompts prompts = new Prompts();

    public Entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        string _prompt = prompts.RandomQuestion();


    {
        public void Display()
        {
            Console.WriteLine($"{_date} - {_prompt}{_userEntry}");
        }
    }
    }
}