using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public void Read(int pagesRead)
    {
        if (pagesRead > Pages)
        {
            Console.WriteLine($"Ошибка! Вы пытаетесь прочитать {pagesRead} стр., но в книге всего {Pages} стр.");
        }
        else
        {
            Console.WriteLine($"Вы прочитали {pagesRead} страниц из {Pages}.");
        }
    }
}