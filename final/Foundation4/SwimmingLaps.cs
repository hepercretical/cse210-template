public class SwimmingLaps : Activity
{
    private int _numOfLaps;

    public SwimmingLaps(int duration, string date, int numOfLaps) : base(duration, date)
    {
        _numOfLaps = numOfLaps;
    }

    public override double CalculateDistance()
    {
        return _numOfLaps * 50 / 1000 * 0.62;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / GetDuration() * 60;
    }

    public override double CalculatePace()
    {
        return GetDuration() / CalculateDistance();
    }

    public override string GetActivityType()
    {
        return "Swimming Laps";
    }
}