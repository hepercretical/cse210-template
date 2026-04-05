public class StationaryBicycles : Activity
{
    private double _speed;

    public StationaryBicycles(int duration, string date, int speed) : base(duration, date)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return Math.Round((_speed * GetDuration()) / 60, 2);
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return Math.Round(GetDuration() / CalculateDistance(), 2);
    }

    public override string GetActivityType()
    {
        return "Stationary Bicycles";
    }
}