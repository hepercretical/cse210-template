using System;

public class ListingActivity : Activity
{
    private static string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private static List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that yo uhave helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    private string _prompt;
    private static int _entries;

    public ListingActivity(int d) : base(d)
    {
        Random random = new Random();
        _prompt = _prompts[random.Next(_prompts.Count())];
    }

    public static string GetDescription()
    {
        return _description;
    }

    public static void Prompt()
    {
        Random random = new Random();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[random.Next(_prompts.Count())]} ---");
    }

    public void Loop()
    {
        DateTime endTime = DateTime.Now.AddSeconds(Activity.GetDuration());
        _entries = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _entries ++;
        }
        Console.WriteLine($"You listed {_entries} items!");
        Console.WriteLine();
    }

    public void RecordEntry()
    {
        _entries++;
    }

    public int GetEntries()
    {
        return _entries;
    }
}