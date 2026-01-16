using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new Book("Мастер и Маргарита", "Михаил Булгаков", 1967),
            new Book("1984", "Джордж Оруэлл", 1949),
            new Book("Гарри Поттер и философский камень", "Джоан Роулинг", 1997),
            new Book("Метро 2033", "Дмитрий Глуховский", 2005),
            new Book("Три товарища", "Эрих Мария Ремарк", 1936),
            new Book("Новая книга", "Современный автор", 2020)
        };

        Console.WriteLine("Список книг:");
        foreach (Book book in books)
        {
            book.DisplayInfo();
        }
    }
}