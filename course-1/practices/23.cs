using System;

public class Device
{
    public string Name { get; set; }
    public void TurnOn()
    {
        Console.WriteLine("Устройство включено.");
    }
    public virtual void Beep()
    {
        Console.WriteLine("Устройство подаёт сигнал.");
    }

}

public class Kettle : Device
{
    public override void Beep()
    {
        Console.WriteLine("Чайник пикнул: пи-пи!");
    }
}

public class Toaster : Device
{
    public override void Beep()
    {
        Console.WriteLine("Тостер пикнул: динь!");
    }
}

public class Program
{
    static void Main()
    {
        var k = new Kettle();
        var t = new Toaster();

        k.Beep();
        t.Beep();
    }
}
