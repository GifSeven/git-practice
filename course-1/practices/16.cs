using System;
using System.Security.Cryptography.X509Certificates;

public class Animal 
{
    public string Name { get; set; }
    public void Eat()
    {
        Console.WriteLine($"{Name} ест.");
    }
}
public class Dog : Animal
{
    public void Bark()
    { 
        Console.WriteLine("Собака лает.");
    }
}
public class Cat: Animal
{
    public void Meow()
    {
        Console.WriteLine("Кошка мяукает.");
    }
}

public class Program
{
    static void Main()
    {
        var dog = new Dog();
        dog.Name = "Шарик";
        dog.Eat();
        dog.Bark();

        var cat = new Cat();
        cat.Name = "Мурка";
        cat.Eat();
        cat.Meow();
    }
}
