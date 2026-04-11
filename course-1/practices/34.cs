using System;
using System.Xml.Linq;

using System;

public abstract class Animal
{
    public string Name { get; }
    public abstract void MakeSound();

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Создано животное: {Name}");
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} ест.");
    }
}
public class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Гав-гав!");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Мяу!");
    }
}

public class Program
{
    static void Main()
    {
        Animal[] animals = { new Dog("Рекс"), new Cat("Мурка") };
        foreach (Animal animal in animals)
        {
            animal.Eat();
            animal.MakeSound();
        }
    }
}