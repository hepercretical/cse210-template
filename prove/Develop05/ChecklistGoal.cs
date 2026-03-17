using System;

public class ChecklistGoal : Goal
{
    private int _reward;
    private int _bonusReward;
    private int _numCompleted;
    private int _totalRequired;

    public ChecklistGoal(string name, string description, int reward, int totalRequired) : base(name, description)
    {
        _reward = reward;
        _bonusReward = reward * totalRequired / 2;
        _numCompleted = 0;
        _totalRequired = totalRequired;
    }

    public ChecklistGoal(string name, string description, int reward, int totalRequired, int numCompleted) : base(name, description)
    {
        _reward = reward;
        _bonusReward = reward * totalRequired / 2;
        _numCompleted = numCompleted;
        _totalRequired = totalRequired;
    }

    public override int GetCompleted()
    {
        return _numCompleted;
    }

    public override int GetRequired()
    {
        return _totalRequired;
    }

    public override string GetGoalType()
    {
        return "ChecklistGoal";
    }

    public override int CalculateReward()
    {
        _numCompleted ++;
        if(_numCompleted != _totalRequired)
        {
            return _reward;
        }
        else
        {
            return _bonusReward;
        }
    }

    public override string SaveGoal()
    {
        return $"{GetGoalType()}~|/{GetName()}~|/{GetDescription()}~|/{_reward}~|/{_totalRequired}~|/{_numCompleted}";
    }

    public override string CheckMarkCheck()
    {
        if (_numCompleted < _totalRequired)
        {
            return " ";
        }
        else
        {
            return "X";
        }
    }
}