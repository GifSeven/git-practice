using System;

public class Device
{
    public string Name { get; set; }
    public void TurnOn()
    {
        Console.WriteLine("Устройство включено.");
    }
}

public class Kettle : Device
{
    public void Boil()
    {
        Console.WriteLine("Чайник кипятит воду.");
    }
}

public class Toaster : Device
{
    public void Toast()
    {
        Console.WriteLine("Тостер поджаривает хлеб.");
    }
}

public class Program
{
    static void Main()
    {
        var kettle = new Kettle();
        kettle.Name = "Redmond";
        kettle.TurnOn();
        kettle.Boil();

        var toaster = new Toaster();
        toaster.Name = "Philips";
        toaster.TurnOn();
        toaster.Toast();
    }
}
