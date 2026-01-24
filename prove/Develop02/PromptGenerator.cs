using System;

// This class takes care of the prompt data and selection of random prompts.
public class PromptGenerator
{
    public static List<string> _prompts;

    // Very basic for now but can easily be expanded on to prepare the list differently depending on which prompts the user has already answered.
    public static void PrepPromptList()
    {
        PromptGenerator._prompts = System.IO.File.ReadAllLines("prompts.txt").ToList();
    }

    // Chooses a prompt from the list at random.
    public static string Generate()
    {
        Random random = new Random();
        string randomPrompt = PromptGenerator._prompts[random.Next(PromptGenerator._prompts.Count())];

        Console.WriteLine();
        Console.WriteLine(randomPrompt);
        return randomPrompt;
    }
}