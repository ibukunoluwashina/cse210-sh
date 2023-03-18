using System;

public class PrompGenerator
{
    public static DateTime GetDate() {
        Console.Write("Enter date (YYYY-MM-DD):");
        string dateStr = Console.ReadLine();
        return DateTime.Parse(dateStr);
    }
    public static string GetContent(){
        Console.Write("Enter lournal entry content: ");
        string content = Console.ReadLine();
        return content;
    }
}