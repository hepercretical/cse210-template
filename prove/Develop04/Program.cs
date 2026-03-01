using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection;
        string activityType = "";

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            userSelection = int.Parse(Console.ReadLine());
            
            if (userSelection != 4)
            {
                if (userSelection == 1)
                {
                    activityType = "Breathing";
                    BreathingActivity activity = new BreathingActivity(Activity.StartActivity(activityType, BreathingActivity.GetDescription()));
                    Activity.GetReady();
                    activity.Loop();
                }

                else if (userSelection == 2)
                {
                    activityType = "Reflecting";
                    ReflectingActivity activity = new ReflectingActivity(Activity.StartActivity(activityType, ReflectingActivity.GetDescription()));
                    Activity.GetReady();
                    ReflectingActivity.Prompt();
                    Console.Clear();
                    activity.Loop();
                }

                else if (userSelection == 3)
                {
                    activityType = "Listing";
                    ListingActivity activity = new ListingActivity(Activity.StartActivity(activityType, ListingActivity.GetDescription()));
                    Activity.GetReady();
                    activity.Loop();
                }
                Activity.EndActivity(activityType);
        }

        } while (userSelection != 4);
    }
}