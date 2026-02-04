using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        Fraction frac2 = new Fraction(99);
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        Fraction frac3 = new Fraction(8, 9);
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        Fraction frac4 = new Fraction(-6, 7);
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());
        
        Fraction f = new Fraction();
        Random random = new Random();
        for (int i = 1; i < 26; i++)
        {
            int randomTop = random.Next(50);
            int randomBottom = random.Next(1, 51);
            f.SetTop(randomTop);
            f.SetBottom(randomBottom);
            Console.WriteLine($"Fraction {i}: string: {f.GetFractionString()} Number: {f.GetDecimalValue()}");
        }
    }
}