class Program
{

    static void Main(string[] args){
        Journal journal = new Journal();

        while (true) {
            Console.WriteLine("\n Please select one of the following choice: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            string choiceStr = Console.ReadLine();
            int choice = int.Parse(choiceStr);

            switch (choice) {
                case 1:
                    DateTime date = PrompGenerator.GetDate();
                    string content = PrompGenerator.GetContent();
                    journal.AddEntry(date, content);
                    break;

                case 2:
                    journal.DisplayEntries();
                    break;

                case 3:
                    Console.WriteLine("Enter a file name: ");
                    string fileNameSave = Console.ReadLine();
                    journal.saveToFile(fileNameSave);
                    break;

                case 4:
                Console.WriteLine("Enter a filename: ");
                string fileNameLoad = Console.ReadLine();
                journal.LoadFromFile(fileNameLoad);
                break;

                case 5:
                    return;

                default:
                    Console.WriteLine("invalid choice.");
                    break;

            }
        }
    }
}