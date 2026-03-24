using System;

public class Animal
{
    protected int energy = 100;

    public void Eat()
    {
        energy += 10;
        Console.WriteLine($"Животное поело. Текущая энергия: {energy}");
    }
    public void ShowEnergy()
    {
        Console.WriteLine($"Энергия: {energy}");
    }
}

public class Dog : Animal
{
    public void Run()
    {
        if (energy >= 20)
        {
            energy -= 20;
            Console.WriteLine($"Собака побегала. Текущая энергия: {energy}");
        }
        else
        {
            Console.WriteLine("Собака слишком устала, чтобы бежать!");
        }
    }
}

public class Program
{
    static void Main()
    {
        var myDog = new Dog();

        myDog.ShowEnergy(); 

        myDog.Eat();        
        myDog.Run();     
        myDog.Run();       
        myDog.Eat();       

        myDog.ShowEnergy(); 

    }
}
