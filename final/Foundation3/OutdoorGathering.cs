public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherSatement) : base("Outdoor Gathering", title, description, date, time, address)
    {
        _weatherStatement = weatherSatement;
    }

    public string GetWeatherStatement()
    {
        return _weatherStatement;
    }
}