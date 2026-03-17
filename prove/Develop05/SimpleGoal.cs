using System;

public class SimpleGoal : Goal
{
    private int _reward;
    private bool _completed;

    public SimpleGoal(string name, string description, int reward) : base(name, description)
    {
        _reward = reward;
        _completed = false;
    }

    public SimpleGoal(string name, string description, int reward, bool completed) : base(name, description)
    {
        _reward = reward;
        _completed = completed;
    }

    public override string GetGoalType()
    {
        return "SimpleGoal";
    }

    public override int CalculateReward()
    {
        _completed = true;
        return _reward;
    }

    public override string SaveGoal()
    {
        return $"{GetGoalType()}~|/{GetName()}~|/{GetDescription()}~|/{_reward}~|/{_completed}";
    }

    public override string CheckMarkCheck()
    {
        if (_completed == true)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }
}