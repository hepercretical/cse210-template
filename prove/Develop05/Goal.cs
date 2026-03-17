using System;
using System.ComponentModel;

public class Goal
{
    private string _name;
    private string _description;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public virtual string GetDescription()
    {
        return _description;
    }

    public void RecordEvent()
    {

    }

    public virtual int CalculateReward()
    {
        return 0;
    }

    public virtual string GetGoalType()
    {
        return "";
    }

    public virtual int GetCompleted()
    {
        return 0;
    }

    public virtual int GetRequired()
    {
        return 0;
    }

    public virtual string SaveGoal()
    {
        return ":)";
    }

    public virtual string CheckMarkCheck()
    {
        return " ";
    }
}