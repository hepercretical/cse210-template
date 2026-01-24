using System;

class Program
{
    static void Main(string[] args)
    {
        //   000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000   //
        //                                                                                                                        //
        //   Showing Creativity and Exceeding Requirements:                                                                       //
        //                                                                                                                        //
        //   In addition to the Journal, Entry, and PromptGenerator classes, I made a UI class to handle user interface things.   //
        //   The UI class takes care of displaying the interactive menu, the carrot each time the user is prompted for an input   //
        //   and other parts of the program that deal primarily with things displayed to the user.                                //
        //                                                                                                                        //
        //   All saves will be saved as a .txt file automatically so the user does not need to type as much when saving.          //
        //                                                                                                                        //
        //   I have added more logic for different situations.                                                                    //
        //   If a user has made a journal entry that has not been saved and tries to load or quit they will be told about their   //
        //   unsaved entries and asked if they still want to continue.                                                            //
        //   If a user loads or saves a file, the name will be remembered. When they want to save again, they will be asked if    //
        //   they would like to save their file to the same file they already have loaded. That way they do not need to type      //
        //   the file name over again.                                                                                            //
        //                                                                                                                        //
        //   The program was really fun to work on but took soooo much longer than I expected because of dealing with variables   //
        //   accross classes that were being stubborn.                                                                            //
        //                                                                                                                        //
        //   000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000   //

        // Reads the file of prompts and puts each prompt into a list to be randomly selected from later.
        PromptGenerator.PrepPromptList();

        // Welcome to the program.
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");

        // Loops over and over until the user is done.
        do
        {
            UI.Menu();
        } while (UI._isQuitting == false);

        // Goodbye!!
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
        Console.WriteLine();
    }
}