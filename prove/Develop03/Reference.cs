using System;
using System.Runtime.InteropServices;

class Reference
{
    private static string _book;
    private static int _chapter;
    private static int _startVerse;
    private static int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    
    public static void CreateReference()
    {
        Reference reference = new Reference("Doctrine and Covenants", 4, 1, 7);
    }

    public static string GetReference()
    {
        string reference;

        if (_endVerse == 0)
        {
            reference = $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }

        return reference;
    }
}