using System;

public class Car
{
    public string Brand { get; private set; }
    public int Speed { get; private set; }

    public Car(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void Accelerate()
    {
        Speed += 10;
    }
}

class Program
{
    static void Main()
    {
        var car = new Car("Audi", 50);

        Console.WriteLine($"{car.Brand} едет со скоростью {car.Speed} км/ч");
    }
}
