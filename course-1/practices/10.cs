using System;


public class Car
{
    public string Brand { get; set; }

    public int Speed { get; set; }

    public void Continue()
    {
        Speed += 10;
    }
}

class Program
{
    static void Main()
    {
        var car = new Car { Brand = "BMW" };

        car.Continue(); 

        Console.WriteLine($"{car.Brand} едет со скоростью {car.Speed} км/ч");
    }
}
