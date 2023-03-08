using System;

// creat the class

public class Reference
{
    // variable declarations so they can be re-used 2 reference
    private string _scripture;
    private string _chapter;
    private string _verse;

    public Reference(string chapter, string verse)
    {
        _scripture = "John";
        _chapter = "3";
        _verse = "16";
    }

    public Reference(string scripture, string chapter, string verse)
    {
        _scripture = "Proverbs";
        _chapter = "3";
        _verse = "5-6";
    }

    public string GetnewScriptures()
    {
        string text = $"{_scripture} {_chapter} {_verse}";
        return text;
    }

    internal bool DisplayScripture()
    {
        throw new NotImplementedException();
    }
}  