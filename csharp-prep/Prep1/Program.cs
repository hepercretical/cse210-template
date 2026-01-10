using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for the first and last name of the user and assign them to string variables names "first" and "last" respectively.
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine();

        // Writes the name of the person as required by the assignment according to the answers provided by the user earlier.
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}