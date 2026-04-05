using System;

class Program
{
    static void Main(string[] args)
    {
        // A list of activities is made and includes at least 1 of each type of activity and all of the relevant information needed for each activity.
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(60, "4 April 2025", 3));
        activities.Add(new StationaryBicycles(26, "15 Oct 2024", 12));
        activities.Add(new SwimmingLaps(17, "4 June 2023", 15));

        // Display each activity for the use by going through the list of activities and using the same method.
        foreach (Activity a in activities)
        {
            Console.WriteLine();
            Console.WriteLine(a.GetSummary());
        }
        
        Console.WriteLine();
    }
}