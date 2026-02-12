using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class Scripture
{
    private List<Word> _scriptureWords;
    
    public Scripture(List<Word> words)
    {
        _scriptureWords = words;
    }

    public static List<Word> GetWords(Scripture s)
    {
        return s._scriptureWords;
    }

    public static void Display(Scripture scripture)
    {
        Console.Clear();
        Console.Write($"{Reference.GetReference()} ");

        string word;
        foreach (Word w in scripture._scriptureWords)
        {
            word = Word.GetWord(w);
            if (Word.IsHidden(w) == false)
            {
                Console.Write($"{word} ");
            }
            else
            {   
                foreach (char c in word)
                {
                    Console.Write("_");
                }
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public static void HideWords(Scripture s, int n, int left)
    {
        if (n > left)
        {
            n = left;
        }
        
        Random random = new Random();
        int randomNum;
        for (int i = 0; i < n; i++)
        {
            randomNum = random.Next(s._scriptureWords.Count);
            if (Word.IsHidden(s._scriptureWords[randomNum]) == false)
                Word.HideWord(s._scriptureWords[randomNum]);
            else
            {
                i = i - 1;
            }
        }
    }
}