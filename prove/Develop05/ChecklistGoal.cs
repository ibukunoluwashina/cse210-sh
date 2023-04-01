public class ChecklistGoal : Goal
{
    public int TargetCount{get; set;}
    public int CompletionCount{get; set;}

    public ChecklistGoal(string name, int PointValue, int TargetCount)
    {
        Name = name;
        PointValue = PointValue;
        isComplete = false;
        TargetCount = targetCount;
        CompletionCount = 0;
    }

    public override string GetProgress()
    {
        return $"completed {CompletionCount}/{TargetCount} times";
    }

    public override void RecordEvent()
    {
        CompletionCount++;
        PointValue += base.PointValue;
        if(CompletionCount == TargetCount)
        {
            PointValue +=500;
            isComplete = true;
        }
    }
}