using System;

public class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Year { get; }

    public bool IsOld => Year < 2006;
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public void DisplayInfo()
    {
        string oldMarker = IsOld ? " [Старая]" : "";
        Console.WriteLine($"«{Title}» — {Author}, {Year}{oldMarker}");
    }
}