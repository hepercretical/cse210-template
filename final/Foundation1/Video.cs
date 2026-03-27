using System.Data;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }

    public void Display()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"By: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"{_comments.Count()} Comments");
        Console.WriteLine();
        
        Console.WriteLine("Comments");
        foreach (Comment c in _comments)
        {
            Console.WriteLine($"{c.GetName()}'s comment:");
            Console.WriteLine (c.GetText());
        }
        Console.WriteLine();
        Console.WriteLine("==========================================");
        Console.WriteLine();
    }
}