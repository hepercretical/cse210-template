public class StationaryBicycles : Activity
{
    private int _speed;

    public StationaryBicycles(int duration, string date, int speed) : base(duration, date)
    {
        _speed = speed
    }

    public override double CalculateDistance()
    {
        return _speed * GetDuration();
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return GetDuration() / CalculateDistance();
    }

    public override string GetActivityType()
    {
        return "Stationary Bicycles";
    }
}