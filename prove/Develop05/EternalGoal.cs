using System;


public class EternalGoal : Goal
{
public bool IsCompleted { get; set; }


public EternalGoal(string name, int pointValue) : base(name, pointValue)
{
    IsCompleted = false;
}

public override void RecordEvent()
{
    IsCompleted = true;
}

public override bool IsComplete()
{
    return IsCompleted;
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