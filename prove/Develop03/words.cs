using System;

// creat the class

public class Word
{
    // variable declarations so they can be re-used 2 reference
    
    
    private String _text;
    private string text;

    public Word()
    {
       _text = "These things I have spoken unto you, that in me ye might have peace. In the world ye shall have tribulation: but be of good cheer; I have overcome the world.";
    }
    
    public Word(string scripture)
    {
        _text = scripture;
    }

    public string DisplayWordString()
    {
        string test = $"{_text}";
        return text;
    }

    
}  

