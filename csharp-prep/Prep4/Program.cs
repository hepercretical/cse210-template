using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Gets variables and list ready for the program.
        List<int> nums = new List<int>();
        int entry;
        string smallestAnswer;

        // Introduces the user.
        Console.WriteLine("");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Uses a do-while to let the user enter numbers until they enter 0.
        do
        {
            Console.Write("Enter number: ");
            entry = int.Parse(Console.ReadLine());
            nums.Add(entry);
        } while (entry != 0);

        // Uses .Where method to go through each number in the list and find the smallest positive number. If there are no positive numbers it will notice.
        var smallestPositive = nums.Where(num => num > 0).OrderBy(num => num).FirstOrDefault();
        if (smallestPositive == 0)
        {
            smallestAnswer = "(no positive numbers)";
        }
        else
        {
            smallestAnswer = smallestPositive.ToString();
        }

        // Tells the user the sum, average, maximum, and minimum posiotive numbers.
        Console.WriteLine();
        Console.WriteLine($"The sum is: {nums.Sum()}");
        Console.WriteLine($"The average is: {nums.Average()}");
        Console.WriteLine($"The largest number is {nums.Max()}");
        Console.WriteLine($"The smallest positive number is: {smallestAnswer}");
        Console.WriteLine();
    }
}