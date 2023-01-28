using System;

class Program
{
    static void Main(string[] args)
    {


        newEntry question1 = new newEntry("If i had one thing i could do over today, what would it be? ");
        newEntry question2 = new newEntry("what was the best part of my day?);
        newEntry question3 = new newEntry("Who was the b3est person i spoke with?);

        //initializing the journal class
        journal newJornal = new journal();
        newJornal._entry.Add(question1);
        newJornal._entry.Add(question2);
        newJornal._entry.Add(question3);

        //initializing the question to be asked
        void question(){
            Console.WriteLine(" 1.   Write");
            Console.WriteLine("2.   Display");
            Console.WriteLine("3. load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5.  Quit");
        }

        //calling the question display function
        void DisplayJournal()
        {   question();
            string ans = Console.ReadLine();
            while (ans != "")
            {

                if(int.Parse(ans) == 1)
                {
                    newJornal.displayQuestion();
                }
                else if (int.Parse(ans) == 2)
                {
                    newJornal.showEntries();
                }
                else if (int.Parse(ans) == 3)
                {
                    newJornal.SaveEntriesToExt();
                }
                else if (int.Parse(ans) == 4)
                {
                    newJornal.loadEntriesFromExt();
                }
        }    
    }
    DisplayJournal();


    }


}