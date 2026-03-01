using System;

public class ReflectingActivity : Activity
{
    private static string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private static List<string> _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    private static string _prompt;
    private static List<string> _questions = ["How was this expereice meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this expereince that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this expereience in mind in the future?"];

    public ReflectingActivity(int d) : base(d)
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
        _prompt = _prompts[random.Next(_prompts.Count())];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {_prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questtions as they related to this experience.");
        Console.Write("You may begin in: ");
        Activity.Countdown(5);
    }

    public void Loop()
    {
        DateTime endTime = DateTime.Now.AddSeconds(Activity.GetDuration());
        Random random = new Random();
        while (DateTime.Now < endTime)
        {
            Console.Write($" > {_questions[random.Next(_questions.Count())]} ");
            Activity.Spinner(7);
            Console.WriteLine();
        }
    }
}