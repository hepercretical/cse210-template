using System;

class Program
{
    static void Main(string[] args)
    {
        ////////////////////Game Setup////////////////////
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);;
        int guess = 0;
        int guesses = 0;
        string playing = "";
        string replay = "";
        Console.WriteLine();
        //////////////////////////////////////////////////

        do
        { 
            //////////////////////////////////////////////////////////////////////////////
            // The user will be told that a number between 1 and 100 had been chosen.   //
            // They will be asked to guess the number. If the user is incorrect, they   // 
            // will be told if their guess was higher or lower than the answer and      //
            // will be prompted to guess again. This will repeat until the user guesses //
            // the number. The number of guesses it takes will also be counted.         //
            //////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine($"I have chosen a {replay}number between 1 and 100.");
            Console.Write("What do you think it is? ");

            do
            {
                if (guesses != 0)
                {
                    Console.Write("Guess again. ");
                }

                guess = int.Parse(Console.ReadLine());
                guesses++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            } while (guess != magicNumber);


            // Tells the user that they got the right answer and how many guesses it took them.
            Console.WriteLine();
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guesses} guesses to figure it out!");
            Console.WriteLine();

            // If the user wants to play again they can.
            Console.Write("Woulc you like to play again? ");
            playing = Console.ReadLine();

            ////////////////////Game Reset////////////////////
            replay = "new ";
            magicNumber = randomGenerator.Next(1,101);
            guesses = 0;
            Console.WriteLine();
            //////////////////////////////////////////////////
        } while (playing == "yes" || playing == "Yes" || playing == "YES" || playing == "Y" || playing == "y");

        Console.WriteLine("Thank You for playing!");
        Console.WriteLine();
    }
}