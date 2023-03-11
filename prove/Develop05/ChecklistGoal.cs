using System;


public class ChecklistGoal : Goal
{
    private int _action = 0;
    private int _point = 0;
    private float _bonus = 0;

    public EternalGoal(int action, int point, float bonus) : base(action, point)
    {
        times = _action;
        point = _point;
        bonus = _bonus; 
    }

    public override GetGoal()
    {
        return (_action * _point) + _bonus;
    }
}