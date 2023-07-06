using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author} - {_length} seconds");
    }
}