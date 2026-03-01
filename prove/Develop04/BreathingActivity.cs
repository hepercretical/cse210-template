using System;

public class BreathingActivity : Activity
{
    private static string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(int d) : base(d)
    {
        
    }

    public static string GetDescription()
    {
        return _description;
    }

    public void Loop()
    {
        DateTime time = DateTime.Now;
        DateTime endTime = time.AddSeconds(GetDuration());
        int breathDuration;
        int numberOfBreaths;

            if (GetDuration() > 10)
        {
            numberOfBreaths = GetDuration() / 5;
            breathDuration = (GetDuration() + 1) / numberOfBreaths;
        }
        else
        {
            breathDuration = (GetDuration() + 1) / 2;
        }

        while (time < endTime)
        {
            Console.WriteLine("Breathe in...");
            BreathingActivity.BreathingAnimation(breathDuration, "==", "-");
            Console.WriteLine("Now breathe out...");
            BreathingActivity.BreathingAnimation(breathDuration, "--", "=");
            Console.WriteLine();
            time = DateTime.Now;
        }
    }

    public static void BreathingAnimation(int duration, string symbol1, string symbol2)
    {
        Console.Write($"[{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}{symbol2}]");
        int timesLeft = 25;
        int deletionsNeeded = timesLeft + 2;
        int additionsNeeded = 1;
        int additionsNeeded2 = timesLeft - 1;
        int times;
        int times2;
        int times3;
        while (timesLeft > 0)
        {
            Thread.Sleep(duration*1000/25);
            times = deletionsNeeded;
            while (times > 0)
            {
                Console.Write("\b \b");
                times --;
            }

            times2 = additionsNeeded;
            while(times2 > 0)
            {
                Console.Write(symbol1);
                times2 --;
            }

            times3 = additionsNeeded2;
            while (times3 > 0)
            {
                Console.Write(symbol2);
                times3 --;
            }
            Console.Write("]");
            timesLeft --;
            deletionsNeeded = deletionsNeeded + 1;
            additionsNeeded = additionsNeeded + 1;
            additionsNeeded2 = additionsNeeded2 - 1;
        }
        Console.WriteLine();
    }
}