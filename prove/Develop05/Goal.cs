using System;

public abstract class Goal
{
    public string Name { get; set; }
    public int PointValue { get; set; }

    public Goal(string name, int pointValue)
{
Name = name;
PointValue = pointValue;
}
public abstract void RecordEvent();

public abstract bool IsComplete();

public abstract int Score { get; }
}
