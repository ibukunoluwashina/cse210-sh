using System;

class Scripture
{

    
    private string _refrence;
    private string _singleVerse;

    public Scripture()
    {
        
        _refrence = "John 3:16";
        _singleVerse = "for God so loved the world that he gave his only begotten son and whosoever ...";

    }

    
    public void addScripture(string refr, string singleV)
    {
        _refrence = refr;
        _singleVerse = singleV;
    }
    public void addScripture(string refr)
    {
        _refrence = refr;
    }
   
    public void displayScripture()
    {
        
        if (_singleVerse.Length < 100)
            Console.WriteLine($"{_refrence} {_singleVerse}");
        wordToList();
        if (_singleVerse.Length > 100)
        {
            Console.WriteLine(_refrence);
            Console.WriteLine(_singleVerse);
        }
    }

    public string wordToList()
    {
        char[] delimeter = { ' ' };
        List<string> wordList = _singleVerse.Split(delimeter).ToList();

        Console.WriteLine("Press Enter to continue or text 'quit' to end");
        string ans = "";
        
        while (_singleVerse != "__" & ans.ToLower() != "quit")
        {
            
            var random = new Random();
            
            int index = random.Next(wordList.Count);
            string wrds = wordList[index];
            
            Console.WriteLine($"{_refrence} {_singleVerse.Replace(wrds, "___")}");
            ans = Console.ReadLine();
            Console.Clear();
        }
        return $"{wordList}";
    }

    
    public void loadFromExt()
    {
        Console.WriteLine("Enter file name");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");

        Console.WriteLine("Enter scripture Name");
        string scriptureName = Console.ReadLine();
        foreach (string line in lines)
        {
            if (scriptureName.ToLower() == line) Console.WriteLine(line);
        }

    }
}