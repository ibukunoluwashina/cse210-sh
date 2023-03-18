using System;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }
    public void DisplayEntries(){
        Console.WriteLine("Journal Entries: \n");

        foreach (Entry entry in entries){
            Console.WriteLine("{0}\n{1}\n", entry.date.ToString(),entry.content);
        }
        
    }
    public void saveToFile(string fileName){
        using (StreamWriter writer = new StreamWriter(fileName)){
            foreach (Entry entry in entries) {
                writer.WriteLine("{0}\n{1}\n", entry.date.ToString(), entry.content);
            }
        }
    }
    public void LoadFromFile(string fileName){
        entries.Clear();
 DateTime date = DateTime.Parse(dateStr);
        using (StreamReader reader = new StreamReader(fileName)){
            while (!reader.EndOfStream) {
                string dateStr = reader.ReadLine();
                string content = reader.ReadLine();
                DateTime date = DateTime.Parse(dateStr);
                entries.Add(new Entry(){ date = date, content = content});
            }
        }
    }

    internal void AddEntry(DateTime date, string content)
    {
        Entry newEntry = new Entry(date, content);

        entries.Add(newEntry);
    }
}