using System;
using System.IO;
using System.Collections.Generic;

public class journal
{

    public List<newEntry> _entry = new List<newEntry>();

    //creating a new list to store the user entries

    List<string> _userDetails = new List<string>();

    //initializing the list where to save the list of the Entry tittle
    List<string> _entryTitle = new List<string>();

    //initializing the method to save the questions
    public void saveQuestions()
    {
        foreach (newEntry entry in _entry)
        {
            //to add multiple data into a list at once in
            string[] userEntries = {
                entry._question,
                entry._date,
                entry._Answer
            };
            _userDetails.AddRange(userEntries);
        }
    }
    public void displayQuestion()
    {
        foreach (newEntry entry in _entry)
        {
            entry.displayQ(entry._question);
            entry._Answer = Console.ReadLine();
            this.saveQuestions();
        }
    }
    public void showEntries()
    {
        if (_userDetails.Count > 0){
        
        foreach (var _item in _userDetails)
        {
            Console.WriteLine(_item);
        }
        }else if (_userDetails.Count < 1){
            Console.WriteLine("Your Entry is Empty");
            Console.WriteLine("Do you want to read from your saved files? Enter Yes/No");
            string _ans = Console.ReadLine();
            if(_ans.ToLower() == "yes"){
                this.loadEntriesFromExt();
            }else{
                this.displayQuestion();
            }
        }
    }

    public void SaveEntriesToExt()
    {
        Console.WriteLine("Enter Filename");
        string _fileName = Console.ReadLine();
        _entryTitle.Add(_fileName);

        using (StreamWriter outputFile = new StreamWriter($"{_filename}.txt))
        {
            foreach (var _item in userDetails)
            {
                outputFile.WriteLine(_item);
            }
            // You can add text to the file with writeline method
        }
    }

    public void loadEntriesFromExt()
    {

        Console.WriteLine("These is/are the files you have");
        foreach (var _title in entryTitle)
        {
            Console.WriteLine(_title);
        }

        Console.WriteLine("Please Enter file name to see the contents")
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(Filename);
        //looping through the contents of the file and printing it to the console
        foreach (string in line in lines)
        { 
            Console.WriteLine(line);
        }
    }
}
