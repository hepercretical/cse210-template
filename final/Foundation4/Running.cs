public class Running : Activity
{
    private int _distance;

    public Running(int duration, string date, int distance) : base(duration, date)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return _distance / GetDuration() *60;
    }

    public override double CalculatePace()
    {
        return GetDuration() / _distance;
    }

    public override string GetActivityType()
    {
        return "Running";
    }
}