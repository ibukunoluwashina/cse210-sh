using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", "16","33");
        Console.WriteLine(reference.DisplayScripture());

        Scripture scripture = new Scripture("And it came to pass", reference);
    }
}