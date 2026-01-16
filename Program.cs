using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Year { get; }

    // Свойство для проверки
    public bool IsOld => Year < 2006;

    // Конструктор
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    // Метод для отображения информации о книге
    public void DisplayInfo()
    {
        string oldMarker = IsOld ? " [Старая]" : "";
        Console.WriteLine($"«{Title}» — {Author}, {Year}{oldMarker}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем список книг
        List<Book> books = new List<Book>
        {
            new Book("Мастер и Маргарита", "Михаил Булгаков", 1967),
            new Book("1984", "Джордж Оруэлл", 1949),
            new Book("Гарри Поттер и философский камень", "Джоан Роулинг", 1997),
            new Book("Метро 2033", "Дмитрий Глуховский", 2005),
            new Book("Три товарища", "Эрих Мария Ремарк", 1936),
            new Book("Новая книга", "Современный автор", 2020)
        };

        // Выводим информацию о всех книгах с помощью foreach
        Console.WriteLine("Список книг:");
        foreach (Book book in books)
        {
            book.DisplayInfo();
        }
    }
}