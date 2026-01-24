using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public static int _entryNum;
    public string _date;
    public string _prompt;
    public string _entry;

    // Makes it easier for creating Entry objects from both loaded lists or user inputs.
    public Entry(string date, string prompt, string entry)
    {
        _date = date;
        _prompt = prompt;
        _entry = entry;
    }

    // Creates a new entry when the user answers a prompt.
    // Entries include the date, prompt, and entry
    // They are added to a list of all entries currently loaded.
    // Also keeps track of how many entries have been made since the user last saved.
    public static void NewEntry()
    {
        Entry instantiateNewEntry = new Entry(DateTime.Now.ToShortDateString(), PromptGenerator.Generate().ToString(), UI.RequestInput().ToString());
        Journal._entries.Add(instantiateNewEntry);
        Journal._entriesSinceSave ++;
    }
}