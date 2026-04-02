public class Activity
{
    private int _duration;
    private string _date;

    public Activity(int duration, string date)
    {
        _duration = duration;
        _date = date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public virtual double CalculateDistance()
    {
        return 1;
    }

    public virtual double CalculateSpeed()
    {
        return 1;
    }

    public virtual double CalculatePace()
    {
        return 1;
    }

    public virtual string GetActivityType()
    {
        return "Unknown";
    }

    public string GetSummarny()
    {
        return $"{_date} {GetActivityType()} ({_duration} min): Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}