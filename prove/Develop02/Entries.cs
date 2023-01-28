using System;

// creat the class

public class newEntry
{
    // variable declarations so they can be re-used 2 reference
    public string _question;
    public string _Answer;
    public string _date;
    
    public newEntry(string _question)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        this._question = _question;
        this._date = dateText;
    }

    public void displayQ(string question){
        Console.WriteLine(question);
    }



       
}