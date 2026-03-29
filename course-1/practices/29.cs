using System;

public class Transport
{
    public string Model { get; set; }

    public virtual void Move()
    {
        Console.WriteLine($"{Model}: транспорт движется.");
    }
}

public class Car : Transport
{
    public override void Move()
    {
        base.Move();
        Console.WriteLine("Машина едет по дороге");
    }
}

public class Boat : Transport
{
    public override void Move()
    {
        base.Move();
        Console.WriteLine("Лодка плывёт по воде");
    }
}


public class Plane : Transport
{
    public override void Move()
    {
        base.Move();
        Console.WriteLine("Самолёт летит в небе");
    }
}
public class Program
{
    static void Main()
    {
        Transport[] vehicles =
        {
    new Car { Model = "Audi" },
    new Boat { Model = "Yamaha" },
    new Plane { Model = "Boeing" }
};

        foreach (var v in vehicles)
        {
            v.Move();
        }
    }
}

