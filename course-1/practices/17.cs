using System;

public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Животное издаёт звук");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Собака говорит: Гав-гав!");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Кошка говорит: Мяу!");
    }
}

public class Program
{
    static void Main()
    {
        var dog = new Dog();
        var cat = new Cat();


        dog.Speak();
        cat.Speak();
    }
}
