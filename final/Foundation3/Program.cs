using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates Lecture event.
        Address lectureAddress = new Address("234 Saintte Hwy 99", "Hominy", "Oklahoma", "United States");
        Lecture lecture = new Lecture("Gnome Culture", "This event will extensively cover the diversity of Gnome culture including appropriate and relevant lore.", "7/4/2026", "10:00 AM CDT", lectureAddress, "Grant Widdison", 75);


        // Creates Reception event.
        Address receptionAddress = new Address("2829 Terra Vista Drive", "Independence", "Kansas", "United States");
        Reception reception = new Reception("Welcoming Christopher Luxon", "This event welcomes the Prime Miniester of New Zealand in his visit to the United States.", "12/18/2026", "6:30 PM CDT", receptionAddress, "receptions@rsvp.gov");


        // Creates OutdoorGathering event.
        Address outdoorGatheringAddress = new Address("704 W 5th Street", "Skiatook", "Oklahoma", "United States");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Skiatook Rodeo Kickoff", "This event marks the kickoff of the week long annual Skiatook rodeo.", "10/21/2026", "5:00 PM CDT", outdoorGatheringAddress, "partly cloudy with a 15% chance of rain");
        Console.WriteLine();
        Console.WriteLine("================================================================");
        Console.WriteLine();

        // Displays Lecture event with each marketing message.
        Console.WriteLine("Lecture Display Results:");
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullDetails(lecture.GetSpeakerName(), lecture.GetCapacity());
        Console.WriteLine();
        lecture.DisplayShortDescription();
        Console.WriteLine();
 
        // Displays Reception event with each marketing message.
        Console.WriteLine("Reception Display Results:");
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayFullDetails(reception.GetEmail());
        Console.WriteLine();
        reception.DisplayShortDescription();
        Console.WriteLine();

        // Displays OutdoorGethering event with each marketing message.
        Console.WriteLine("Outdoor Gathering Display Results:");
        outdoorGathering.DisplayStandardDetails();
        Console.WriteLine();
        outdoorGathering.DisplayFullDetails(outdoorGathering.GetWeatherStatement());
        Console.WriteLine();
        outdoorGathering.DisplayShortDescription();
        Console.WriteLine();
    }
}