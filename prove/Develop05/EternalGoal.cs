using System;

public class EternalGoal : Goal
{
    private int _reward;

    public EternalGoal(string name, string description, int reward) : base(name, description)
    {
        _reward = reward;
    }

        public override string GetGoalType()
    {
        return "EternalGoal";
    }

    public override int CalculateReward()
    {
        return _reward;
    }

    public override string SaveGoal()
    {
        return $"{GetGoalType()}~|/{GetName()}~|/{GetDescription()}~|/{_reward}";
    }
}