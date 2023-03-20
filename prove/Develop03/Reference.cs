using System;

class Refrence{

    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    public Refrence()
    {

    }

    public Refrence(string bk, string ch, string vr){
        _book = bk;
        _chapter = ch;
        _verse = vr;
    }

    
    public Refrence(string bk, string ch, string vr, string endVr){
        _book = bk;
        _chapter = ch;
        _verse = vr;
        _endVerse = endVr;
    }
    
    public string getRefrence(){
        if(_endVerse != null){
            string text = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        return text;
        }else{
            string text =$"{_book} {_chapter}:{_verse}";
            return text;
        }
    }
}