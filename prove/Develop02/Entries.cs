using System;

public class Entry{
    public DateTime date;
    public string content;

    public Entry()
    {
    }

    public Entry(DateTime date, string content)
    {
        this.date = date;
        this.content = content;
    }
}