using System;


public class EternalGoal : Goal
{
    public EternalGoal(string name, int PointValue)
    {
        Name = name;
        PointValue = PointValue;
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