using System;

using System.Collections.Generic;

 class program{
    static void Main(string[] args)
    {
        

        string verse1 = "prov 3:4";
        string proverb = "for God so love the world that he gave his only begotten .......";
        string verse2 = "matt 5:6";
        string matt = "In the beginning......";
        
        Refrence refrence = new Refrence("Matt", "3", "15");
        string r = refrence.getRefrence();
        Console.WriteLine(r);
        Word word = new Word();
        string wrd = word.addWord(proverb);
     
        Scripture scripture = new Scripture();
        scripture.addScripture(r,proverb);
        

        Console.WriteLine("Load Scripture from external file or from available scriptures? yes/no");
        string ans = "";
        if(ans.ToLower() != "no"){
        scripture.displayScripture();
        }else{
         scripture.loadFromExt();
        }




    }
 }