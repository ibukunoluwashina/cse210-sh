public class Prompts
{
    public List<string> _question = new List<string>()
{
    "What was the best part of your day?",
    "Who did you talk to today?",
    "How would you describe my mood lately?",
    "What moment of revelation did you have today?",
    "What are my goal for the next month?"
};

public string RandomQuestion()
{
    Random random = new Random();
    int index = random.Next(_questions.Count);
    Console.writeLine(index)
    return _question[index];
}
}