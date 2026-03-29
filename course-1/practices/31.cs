using System;
using System.Diagnostics.Contracts;

public class Instrument
{
    public virtual void Play()
    {
        Console.WriteLine("Инструмент издаёт звук");
    }
}

public class Guitar : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Гитара играет аккорды");
    }
}

public class Piano : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Пианино играет мелодию");
    }
}

public class Drum : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Барабан бьёт ритм");
    }
}
public class Program
{
    static void Main()
    {
        Instrument[] instruments =
        {
    new Guitar(),
    new Piano(),
    new Drum()
};

        foreach (var i in instruments)
        {
            i.Play();
        }
    }
}