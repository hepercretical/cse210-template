using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureQuote = "Now behold, a marvelous work is about to come forth among the children of men. Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day. Therefore, if ye have desires to serve God ye are called to the work; For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with his might, the same layeth up in store that he perisheth not, but bringeth salvation to his soul; And faith, hope, charity and love, with an eye single to the glory of God, qualify him for the work. Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence. Ask, and ye shall receive; knock, and it shall be opened unto you. Amen.";
        Reference.CreateReference();
        Scripture scripture = new Scripture(Word.GetWords(scriptureQuote));
        int hideAmmount = 3;
        int wordsLeft;
        string quit = "";

        do
        {
            Scripture.Display(scripture);
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.Write("> ");
            quit = Console.ReadLine();

            wordsLeft = Word.CheckLeftToHide(Scripture.GetWords(scripture)); 
            Scripture.HideWords(scripture, hideAmmount, wordsLeft);
        } while (quit != "quit" ^ wordsLeft == 0);
        Console.Clear();
        Console.WriteLine("Goodbye!");
    }
}