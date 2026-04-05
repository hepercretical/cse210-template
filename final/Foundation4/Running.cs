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
        return Math.Round((_distance / (GetDuration()) * 60), 2);
    }

    public override double CalculatePace()
    {
        return Math.Round(GetDuration() / _distance, 2);
    }

    public override string GetActivityType()
    {
        return "Running";
    }
}