using System;
public class SimpleGoal : Goal
{
public int TimesCompleted { get; set; }
public int RequiredTimes { get; set; }



public SimpleGoal(string name, int pointValue) : base(name, pointValue)
{
    RequiredTimes = 1;
}

public override void RecordEvent()
{
    TimesCompleted++;
}

public override bool IsComplete()
{
    return TimesCompleted >= RequiredTimes;
}

public override int Score
{
    get
    {
        if (IsComplete())
        {
            return PointValue;
        }
        else
        {
            return 0;
        }
    }
}
}