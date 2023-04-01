using System;

public abstract class Goal
{
    public string Name { get; set; }
    public int PointValue { get; set; }
    public bool isComplete{get; set;}

    public abstract string GetProgress();

    public virtual void RecordEvent()
{
    isComplete = true;
}
}
