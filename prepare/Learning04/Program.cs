using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Shows the base class working.
        Assignment assignment = new Assignment("Janice Dean", "Health");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        // Shows the MathAssignment class working.
        MathAssignment mAssignment = new MathAssignment("Steve Combs", "Algebra", "2.7", "17-38");
        Console.WriteLine(mAssignment.GetSummary());
        Console.WriteLine(mAssignment.GetHomeworkList());
        Console.WriteLine();

        // Shows the WritingAssignment class working.
        WritingAssignment wAssignment = new WritingAssignment("Brad Baker", "Persuasive Writing", "This is a Good Paper");
        Console.WriteLine(wAssignment.GetSummary());
        Console.WriteLine(wAssignment.GetWritingInformation());
        Console.WriteLine();
    }
}