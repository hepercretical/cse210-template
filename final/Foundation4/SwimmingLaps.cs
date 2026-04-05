using System.Runtime.Intrinsics.X86;

public class SwimmingLaps : Activity
{
    private double _numOfLaps;

    public SwimmingLaps(int duration, string date, int numOfLaps) : base(duration, date)
    {
        _numOfLaps = numOfLaps;
    }

    public override double CalculateDistance()
    {
        return Math.Round(_numOfLaps * 0.0310686, 2);
    }

    public override double CalculateSpeed()
    {
        return Math.Round(CalculateDistance() / GetDuration() * 60, 2);
    }

    public override double CalculatePace()
    {
        return Math.Round(GetDuration() / CalculateDistance(), 2);
    }

    public override string GetActivityType()
    {
        return "Swimming Laps";
    }
}