using System;
class Word{

   
    private string _words;

    public string addWord(string wrd){
        _words = $"{wrd}";
        return _words;
    }
   
    public void checkWord(){
        Console.WriteLine(_words);
    }
}