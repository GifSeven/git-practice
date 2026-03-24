using System;

public class Person
{
    private int _age; 
    private string _name; 

    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 0)
                _age = value;
            else
                Console.WriteLine("Возраст не может быть отрицательным!");
        }
    }

    public string Name
    {
        get { return _name; } 
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _name = value;
            else
                Console.WriteLine("Имя нельзя задать пустым.");
        }
    }
}

public class Program
{
    static void Main()
    {
        var p = new Person();
        p.Name = "Алиса";
        p.Age = 25;
        p.Age = -5; 

        Console.WriteLine($"Имя: {p.Name}, Возраст: {p.Age}");
    }
}

