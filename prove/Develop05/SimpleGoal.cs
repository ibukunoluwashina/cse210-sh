using System;
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int pointValue)
    {
        Name = name;
        PointValue = pointValue;
        isComplete = false;
    }
    public override string GetProgress()
    {
        return isComplete ? "[x]" : "[ ]";
    } 
}