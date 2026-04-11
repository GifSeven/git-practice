using System;


public abstract class Transport
{
    public void Move()
    {
        Start();
        MoveCore();
        Stop();
    }
    protected void Start()
    {
        Console.WriteLine("Старт");
    }
    protected void Stop()
    {
        Console.WriteLine("Стоп");
    }
    protected abstract void MoveCore();
}

public class Car : Transport
{
    protected override void MoveCore()
    { 
        Console.WriteLine("Машина едет по дороге");
    }
}

public class Boat : Transport
{
    protected override void MoveCore()
    {
        Console.WriteLine("Лодка плывёт по воде");
    }
}
public class Program
{
    static void Main()
    {
        Transport[] t = { new Car(), new Boat() }; 
        foreach (var x in t) x.Move();
    }
}