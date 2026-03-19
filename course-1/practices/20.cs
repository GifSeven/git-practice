using System;

public class Transport
{
    public virtual void Drive()
    {
        Console.WriteLine("Транспорт движется");
    }
}

public class Car : Transport
{
    public override void Drive()
    {
        Console.WriteLine("Машина едет по дороге");
    }
}

public class ElectricCar : Car
{
    public override void Drive()
    {
        Console.WriteLine("Электромобиль тихо едет на батарее");
    }
}

public class Program
{
    static void Main()
    {
        var transport = new Transport();
        var car = new Car();
        var tesla = new ElectricCar();

        transport.Drive();
        car.Drive();
        tesla.Drive();
    }
}
