using System;
using System.Runtime.InteropServices;

class Reference
{
    private static string _book;
    private static int _chapter;
    private static int _startVerse;
    private static int _endVerse;

    public Reference(string b, int c, int v)
    {
        _book = b;
        _chapter = c;
        _startVerse = v;
        _endVerse = 0;
    }

    public Reference(string b, int c, int v1, int v2)
    {
        _book = b;
        _chapter = c;
        _startVerse = v1;
        _endVerse = v2;
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