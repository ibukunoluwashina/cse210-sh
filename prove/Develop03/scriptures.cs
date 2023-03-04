using System;

// creat the class

public class Scripture
{
    // variable declarations so they can be re-used 2 reference
    private string _textOfScripture;
    private Reference _reference;
    private List<Word> _words;
    private object puplic;

    public Scripture(string textOfScripture, Reference reference)
    {
        _words = new List<Word>();
        _textOfScripture = textOfScripture;
        _reference = reference;

        string[] array = _textOfScripture.Split(" ");

        foreach(string text in array)
        {
            Word word = new Word(text);
            _word.Add(word);
        }

    puplic void HideWord()
    {
        foreach(Word word in _words)
        {
            word.HideWord();
        }
    }
    }


    }