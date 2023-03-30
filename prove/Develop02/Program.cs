using System;
public class Program
{
    static List<Entry> journal = new List<Entry>();
    static List<string> prompts = new List<string>(){
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    static void Main(string[] args){
               while(true){
                Console.WriteLine("Menu Option:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch(choice) {
                    case "1":
                        WriteNewEntry();
                        break;

                    case "2":
                        DisplayJournal();
                        break;

                    case "3":
                        SaveJournalToFile();
                        break;

                    case "4":
                        LoadJournalFromFile();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
               }
         }
         static void WriteNewEntry(){
            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            Entry entry = new Entry(){
                Prompt = prompt,
                Response = response,
                Date = DateTime.Now
            };
            journal.Add(entry);
         }

         static void DisplayJournal(){
            foreach (Entry entry in journal) {
                Console.WriteLine("{0} ({1}): {2}", entry.Prompt, entry.Date, entry.Response);
            }
         }
         static void SaveJournalToFile(){
            Console.Write("Enter a file name: ");
            string fileName = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(fileName)){
                foreach (Entry entry in journal){
                    writer.WriteLine("{0}\t{1}\t{2}", entry.Prompt, entry.Date, entry.Response);
                }
            }
         }
         static void LoadJournalFromFile(){
            Console.Write("Enter a file name: ");
            string fileName = Console.ReadLine();
            List<Entry> newJournal = new List<Entry>();
            using (StreamReader reader = new StreamReader(fileName)){
                string line;
                while((line = reader.ReadLine()) != null){
                    string[] parts = line.Split('\t');
                    var entry = new Entry(){
                        Prompt = parts[0],
                        Date = DateTime.Parse(parts[1]),
                        Response = parts[2]
                    };
                    newJournal.Add(entry);
                }
            }
         }
}