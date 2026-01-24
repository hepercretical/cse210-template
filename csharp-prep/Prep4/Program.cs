using System;

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
        nums.Sort();

        // Just read the FAQ and realized I used a lambda here before so I went ahead and used a loop to figure out the smallest positive number.
        // 0 is the default output and if it is returned then we will know there was no positive numbers.
        // Loop breaks at the first positive number since the list is already sorted.
        int smallestPositive = 0;
        foreach (int n in nums)
        {
            if (n <= 0)
            {
            }
            else
            {
                smallestPositive = n;
                break;
            }
        }

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

        // Gives the user the sorted list.
        Console.WriteLine();
        Console.WriteLine("The sorted list is:");
        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine();
    }
}