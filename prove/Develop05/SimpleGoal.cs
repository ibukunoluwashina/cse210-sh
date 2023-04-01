using System;
public class SimpleGoal : Goal
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int PointValue)
        {
            Name = name;
            PointValue = PointValue;
            isComplete = false;
        }
        public override string GetProgress()
        {
            return isComplete ? "[x]" : "[ ]";
        }
    }
}