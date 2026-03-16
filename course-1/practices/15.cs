using System;

class Program
{
    static void Main()
    {
        var b1 = new Book();                   
        var b2 = new Book("1984");              
        var b3 = new Book("Гарри Поттер", "Дж. Роулинг");  

        b1.PrintInfo();
        Console.WriteLine();
        b2.PrintInfo();
        Console.WriteLine();
        b3.PrintInfo();
        Console.WriteLine();

    }
}

public class Book
{
    private string title;      
    private string author;      
    private int pages;          

    public Book()
    {
        this.title = "Нет названия";
        this.author = "Неизвестный автор";
        this.pages = 0;
    }

    public Book(string title)
    {
        this.title = title;
        this.author = "Неизвестный автор";
        this.pages = 0;                   
    }

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
        this.pages = 0;         
    }

    public Book(string title, string author, int pages)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Название: {title}");
        Console.WriteLine($"Автор: {author}");
        if (pages > 0)
            Console.WriteLine($"Количество страниц: {pages}");
        else
            Console.WriteLine("Количество страниц неизвестно.");
    }
}
