using System;
using System.Diagnostics;

class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string w)
    {
        _word = w;
        _isHidden = false;
    }

    public static List<Word> ProcessQuote(string quote)
    {   
        string[] individualWords = quote.Split(' ');
        List<Word> listOfWords = new List<Word>();

        foreach (string w in individualWords)
        {
            Word word = new Word(w);
            listOfWords.Add(word);
        }

        return listOfWords;
    }

    public static List<Word> GetWords(string quote)
    {
        List<Word> words = ProcessQuote(quote);
        return words;
    }

    public static string GetWord(Word w)
    {
        return w._word;
    }

    public static void HideWord(Word w)
    {
        w._isHidden = true;
    }

    public static bool IsHidden(Word w)
    {
        if (w._isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int CheckLeftToHide(List<Word> words)
    {
        int left = 0;
        foreach (Word word in words)
        {
            if (word._isHidden == false)
            {
                left ++;
            }
        }
        return left;
    }
}