using System;


public class EternalGoal : Goal
{
    private int _action = 0;
    private int _point = 0;

    public EternalGoal(int action, int point) : base(action, point)
    {
        times = _action;
        point = _point;
    }

    public override GetGoal()
    {
        return _action * _point;
    }

    
}