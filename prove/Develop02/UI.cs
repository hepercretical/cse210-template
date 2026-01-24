using System;

// Takes care of things that the user interacts with such as the main menu, the place where the user types, and such.
public class UI
{
    public static bool _isQuitting;

    // Displays the main menu to the user and responds to their selection.
    public static void Menu()
    {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        int userSelection = int.Parse(UI.RequestInput());

        if (userSelection == 1)
        {
            Entry.NewEntry();
        }
        else if (userSelection == 2)
        {
            UI.Display();
        }
        else if (userSelection == 3)
        {
            Journal.Load();
        }
        else if (userSelection == 4)
        {
            Journal.Save();
        }
        else if (userSelection == 5)
        {
            UI.Quit();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Sorry, that is not one of your options.");
        }
    }
    

    // Displays a carrot for the user when they need to enter an input.
    public static string RequestInput()
    {
        Console.Write(" > ");
        return Console.ReadLine();
    }

    // Displays all journal entries that are currently loaded.
    public static void Display()
    {
        foreach (Entry entry in Journal._entries)
        {
            Console.WriteLine();
            Console.WriteLine($"Date: {entry._date} - {entry._prompt}");
            Console.WriteLine(entry._entry);
        }
    }

    // Takes care of when the user wants to quit, making sure that they saved any new entries before quitting.
    public static void Quit()
    {
        int quitCheck = Journal.SaveCheck("quit");
        if (quitCheck == 1)
        {
            UI._isQuitting = true;
        }
        else if (quitCheck == 3)
        {
            UI.Quit();
        }
    }
}