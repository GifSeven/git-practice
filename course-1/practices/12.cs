using System;

public class Dog
{
    var dog = new Dog { Name = "Шарик" };
    var dog2 = new Dog { Name = "Шарик" }
    Console.WriteLine(dog.ToString());
    Console.WriteLine(dog.GetType());
    Console.WriteLine(dog.Equals(dog2));
}