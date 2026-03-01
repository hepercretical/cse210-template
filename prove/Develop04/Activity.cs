using System;
using System.ComponentModel.DataAnnotations;

public class Activity
{
    private static int _duration;

    public Activity(int duration)
    {
        _duration = duration;
    }

    public static int StartActivity(string activity, string description)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activity} Activity.");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        return int.Parse(Console.ReadLine());
    }

    public static int GetDuration()
    {
        return _duration;
    }

    public static void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready... ");
        LoadingBar(2);
    }

    public static void LoadingBar(int duration)
    {
        Console.Write("[-------------------------]");
        int stuffLeft = 25;
        int times;
        int times2;
        while (stuffLeft != 0)
        {
            Thread.Sleep(duration*1000/25);
            times = stuffLeft;
            while (times != -1)
            {
                Console.Write("\b \b");
                times --;
            }

            Console.Write("=");

            times2 = stuffLeft;
            while (times2 != 1)
            {
                Console.Write("-");
                times2 --;
            }
            Console.Write("]");
            stuffLeft --;
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public static void Spinner(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Console.Write("-");
        while (DateTime.Now < endTime)
        {
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
        }
        Console.Write("\b \b");
    }

    public static void Countdown(int duration)
    {
        while (duration > 0)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            duration --;
        }
        Console.Write("0");
    }

    public static void EndActivity(string activityType)
    {
        Console.WriteLine("Well done!");
        Activity.Spinner(2);
        Console.WriteLine();
        
        Console.WriteLine($"You have completed another {_duration} seconds of the {activityType} activity.");
        Activity.Spinner(5);
    }
}