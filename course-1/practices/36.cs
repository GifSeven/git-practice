using System;


public abstract class DocumentExporter
{
    public abstract string FormatName { get; }
    public abstract void Export(string content);
    public void ShowInfo(string content)
    { 
        Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
    }
}

public class TxtExporter : DocumentExporter
{
    public override string FormatName => "TXT";
    public override void Export(string content)
    {
        Console.WriteLine("Сохраняем текстовый файл");
    }
}

public class PdfExporter : DocumentExporter
{
    public override string FormatName => "PDF";
    public override void Export(string content)
    {
        Console.WriteLine("Создаём PDF-документ");
    }
}
public class Program
{
    static void Main()
    {
        DocumentExporter[] exporters =
        {
    new TxtExporter(),
    new PdfExporter()
};

        foreach (var e in exporters)
        {
            e.ShowInfo("Hello world!");
            e.Export("Hello world!");
        }
    }
}