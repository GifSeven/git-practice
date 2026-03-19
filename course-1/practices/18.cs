using System;

public class Animal
{
    public virtual void Move()
    {
        Console.WriteLine("Животное двигается.");
    }
}

public class Dog : Animal
{
    public override void Move()
    {
        base.Move();
        Console.WriteLine("Собака бежит по дороге.");
    }
}

public class Program
{
    static void Main()
    {
        var dog = new Dog();
        dog.Move();
    }
}
