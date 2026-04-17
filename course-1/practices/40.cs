using System;


public interface IReadable
{
    void Read(string filename);
}

public interface IWritable
{
    void Write(string filename, string content);
}

public interface ISavable
{
    void Save();
}
public class TextDocument : IReadable, IWritable, ISavable
{
    private string content;

    public void Read(string filename)
    {
        Console.WriteLine($"Чтение из файла {filename}");
        content = "Текст из файла";
    }

    public void Write(string filename, string content)
    {
        Console.WriteLine($"Запись в файл {filename}: {content}");
        this.content = content;
    }

    public void Save()
    {
        Console.WriteLine($"Файл сохранён. Содержимое: {content}");
    }
}


public class Program
{
    static void Main()
    {
        TextDocument doc = new TextDocument();
        doc.Read("data.txt");
        doc.Write("data.txt", "Привет, мир!");
        doc.Save();
    }
}