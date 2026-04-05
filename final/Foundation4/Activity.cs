public class Activity
{
    private double _duration;
    private string _date;

    public Activity(int duration, string date)
    {
        _duration = duration;
        _date = date;
    }

    public double GetDuration()
    {
        return _duration;
    }

    public virtual double CalculateDistance()
    {
        return 9999999999999999999;
    }

    public virtual double CalculateSpeed()
    {
        return 9999999999999999999;
    }

    public virtual double CalculatePace()
    {
        return 9999999999999999999;
    }

    public virtual string GetActivityType()
    {
        return "Unknown";
    }

    public string GetSummary()
    {
        return $"{_date} {GetActivityType()} ({_duration} min): Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}