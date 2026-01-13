using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        string userName = PromptUserName();
        int favNum = PromptUserNumber();
        int birthYear = PromptUserBirthYear();
        int squaredNumber = SquareNumber(favNum);
        DisplayResult(userName, squaredNumber, birthYear);
        Console.WriteLine();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string answer = Console.ReadLine();
        return answer;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int answer = int.Parse(Console.ReadLine());
        return answer;
    }

    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        int answer = int.Parse(Console.ReadLine());
        return answer;
    }

    static int SquareNumber(int num)
    {
        int answer = num * num;
        return answer;
    }

    static void DisplayResult(string name, int number, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {number}.");
        Console.WriteLine($"{name}, you will turn {2026 - year} this year.");
    }
}