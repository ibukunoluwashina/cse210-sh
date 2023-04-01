using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int pointValue)
    {
        Name = name;
        PointValue = pointValue;
        isComplete = false;
    }

    public override string GetProgress()
    {
        return "∞";
    }

    public override void RecordEvent()
    {
        PointValue += base.PointValue;
    }
}