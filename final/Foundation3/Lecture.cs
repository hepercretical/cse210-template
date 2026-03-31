public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity) : base("Lecture", title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string GetSpeakerName()
    {
        return _speakerName;
    }

    public int GetCapacity()
    {
        return _capacity;
    }
}