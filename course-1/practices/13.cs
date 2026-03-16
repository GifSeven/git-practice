using System;

class Phone
{
    public string Model { get; set; }

    public int Battery { get; private set; }

    public void Charge(int amount)
    {
        if (amount >= 0)
        {
            Battery += amount;
            if (Battery > 100)
                Battery = 100;
        }
    }

    public void Use(int amount)
    {
        if (amount >= 0 && Battery >= amount)
        {
            Battery -= amount;
        }
        else if (Battery < amount)
        {
            Battery = 0;
        }
    }
}

class Program
{
    static void Main()
    {
        var phone = new Phone { Model = "Samsung Galaxy" };

        Console.WriteLine("Начальное состояние:");
        Console.WriteLine($"Модель: {phone.Model}");
        Console.WriteLine($"Заряд: {phone.Battery}%");

        phone.Charge(30);   
        Console.WriteLine("После зарядки:");
        Console.WriteLine($"Заряд: {phone.Battery}%");

        phone.Use(10);   
        Console.WriteLine("После использования:");
        Console.WriteLine($"Заряд: {phone.Battery}%");
    }
}

