using System;

public class Journal
{
    public static List<Entry> _entries = new List<Entry>();
    public static string _currentFileName;
    public static string _saveFileName;
    public static int _entriesSinceSave = 0;

    // Loads all entries from a file named by the user.
    // Will check if they have any unsaved entries to save before they load another file.
    // Loaded entries will immediately be displayed to the user and they will be told how many entries were loaded.
    public static void Load()
    {
        int loadCheck = Journal.SaveCheck("laod");

        if (loadCheck == 2)
        {
        }
        else if (loadCheck == 3)
        {
            Journal.Load();
        }
        else
        {
            Journal._entries.Clear();
            int loadCount = 0;

            Console.WriteLine();
            Console.WriteLine("What is the name of the file you would like to load?");
            Journal._currentFileName = $"{UI.RequestInput()}.txt";

            string[] lines = System.IO.File.ReadAllLines(Journal._currentFileName);

            foreach (string line in lines)
                {
                string[] parts = line.Split("~|/");
                string date = parts[0];
                string prompt = parts[1];
                string entry = parts[2];

                Entry loadEntry = new Entry(date, prompt, entry);
                Journal._entries.Add(loadEntry);
                loadCount ++;
                }

            UI.Display();
            Console.WriteLine();
            Console.Write($"Successfully loaded {loadCount} of your journal entries!");
        }
    }
    
    // Checks for unsaved data that will be lost if action is taken.
    // If there is they can choose to continue, save before continuing, or quit.
    // Outputs their choice.
    // 1 means continue with action.
    // 2 means to go back.
    // 3 means invalid input.
    public static int SaveCheck(string action)
    {
        if (Journal._entriesSinceSave > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {Journal._entriesSinceSave} unsaved entries that will be lost if you {action} now.");
            Console.WriteLine($"Are you sure you want to {action} now?");
            Console.WriteLine("1. Continue");
            Console.WriteLine("2. Save First");
            Console.WriteLine("3. Cancel");

            int isSure = int.Parse(UI.RequestInput());

            if (isSure == 1)
            {
                Journal._entriesSinceSave = 0;
                return 1;
            }
            else if (isSure == 2)
            {
                Journal.Save();
                return 1;
            }
            else if (isSure == 3)
            {
                return 2;
            }
            else if (isSure > 3 || isSure < 1)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, that is not one of your options.");
                return 3;
            }
            else
            {
                
                return 2;
            }
        }
        else
        {
            return 1;
        }
    }

    // Saves all entries that are loaded or have been created and stores them in a file named by the user.
    // If the user has already saved or loaded previously, it will ask if they want to save to that same file.
    public static void Save()
    {
        if (Journal._currentFileName != "")
        {
            Console.WriteLine();
            Console.WriteLine($"Do you want to save to {Journal._currentFileName}?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            int ask = int.Parse(UI.RequestInput());
            if (ask == 2)
            {
                Journal._currentFileName = "";
            }
        }
        
        if (Journal._currentFileName == "")
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to name your journal file?");
            Journal._currentFileName = $"{UI.RequestInput()}.txt";
        }

        using (StreamWriter outputFile = new StreamWriter(Journal._currentFileName))
        {
            foreach (Entry entry in Journal._entries)
            {
                outputFile.WriteLine($"{entry._date}~|/{entry._prompt}~|/{entry._entry}");
            }
        }
        Journal._entriesSinceSave = 0;

        Console.WriteLine();
        Console.Write($"Successfully saved {Journal._currentFileName}.");
    }
}
