using System;


public class SimpleGoal : Goal
{
    private int _action = 0;
    private int _point = 0;

    public SimpleGoal(int action, int point) : base(action, point)
    {
        action = _action;
        point = _point;
    }

    public override GetGoal()
    {
        return _action * _point;
    }

    
}