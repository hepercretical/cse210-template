using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string n, string t, string title) : base(n, t)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}