public class Event
{
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Event: {_title} - {_description}");
        Console.WriteLine($"{_time} @ {_address.GetAddress()}");
    }

    public void DisplayFullDetails(string detail1, int detail2 = 0)
    {
        DisplayStandardDetails();
        Console.Write($"This event is a {_type}. ");
        if (_type == "Lecture")
        {
            Console.WriteLine($"{detail1} will be speaking and the event has a maximum capacity of {detail2}.");
        }
        else if (_type == "Reception")
        {
            Console.WriteLine($"Please RSVP via email to {detail1}.");
        }
        else if (_type == "Outdoor Gathering")
        {
            Console.WriteLine($"The weather during the gathering is expected to be {detail1}.");
        }
        else
        {
            Console.WriteLine();
        }
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"The {_type} {_title} is on {_date}.");
    }
}