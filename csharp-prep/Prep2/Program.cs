using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks the user for their current percentage for the course and stores it as an integer in the variable intGrade.
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int intGrade = int.Parse(gradeInput);

        // Assigns a letter grade to the strGrade variable depending on the percentage that the user inputted.
        string strGrade;
        if (intGrade >= 90)
        {
            strGrade = "A";
        }
        else if (intGrade >= 80)
        {
            strGrade = "B";
        }
        else if (intGrade >= 70)
        {
            strGrade = "C";
        }
        else if (intGrade >= 60)
        {
            strGrade = "D";
        }
        else
        {
            strGrade = "F";
        }
        
        // Gives the letter grade a + or - if applicable.
        string plusOrMinus;
        if (intGrade % 10 >= 7 && strGrade != "A" && strGrade != "F")
        {
            plusOrMinus = "+";
        }
        else if (intGrade % 10 < 3 && strGrade != "F")
        {
            plusOrMinus = "-";
        }
        else
        {
            plusOrMinus = "";
        }

        // Assigns the string "a" or "an" to the aOrAn variable debending on which would be gramatically correct for the sentence at the end.
        string aOrAn;
        if (strGrade == "A" || strGrade == "F")
        {
            aOrAn = "an";
        }
        else
        {
            aOrAn = "a";
        }
        
        // Congratulates or encourages the user depending on if they are passing the class or not.
        if (intGrade >= 70)
        {
            Console.WriteLine($"Your grade is {aOrAn} {strGrade}{plusOrMinus}, and you are currently passing your course. Congratulations!");
        }
        else
        {
            Console.WriteLine($"Your grade is {aOrAn} {strGrade}{plusOrMinus}, and you are currently failing your course. Increase your study time and your grade should improve!");
        }
    }
}