using System;
class Entry
{
    private string _ref;
    public string _verse;
    internal readonly int length;

    // This is a constructor with specific arguments
    public Entry(string refr, string verses)
    {
        _ref = refr;
        _verse = verses;
    }

    // This is a no-argument constructor for setting default values of an object.
    public Entry() { }
    public string addRef(string refrence)
    {
        _ref = refrence;
        return _ref;
    }
    List<string> list = new List<string> { };
    List<string> list2 = new List<string> { };
    public string addVerse(string verse)
    {
        _verse = verse;
        return _verse;
    }
    // method to add the scripture as a string into the available list
    public void addScripture(string r, string v)
    {
        list.Add($"{r}, {v}");
    }
    public void displayQ()
    {
        var random = new Random();
        int index = random.Next(list.Count);
        string count = list[index];
        Console.WriteLine(count);

    }

    public void addScripture2(string r, string v)
    {
        list2.Add($"{r},{v}");
    }

    public void displayQ2()
    {
        var random = new Random();
        int index = random.Next(list2.Count);
        string count = list2[index];
        Console.WriteLine(count);
    }
}