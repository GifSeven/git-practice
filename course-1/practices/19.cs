using System;
using System.Xml.Linq;

public class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Создано животное: {Name}");
    }

}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        Console.WriteLine($"Создана кошка по имени {Name}");
    }
}

public class Program
{
    static void Main()
    {
        var cat = new Cat("Мурка");
    }
}