using System;

public class Thermometer
{
    private double _temperatureCelsius;

    public double TemperatureCelsius
    {
        get => _temperatureCelsius;
        set
        {
            if (value >= -273)
            {
                _temperatureCelsius = value;
            }
            else
            {
                Console.WriteLine("Ошибка: температура не может быть ниже абсолютного нуля (-273°C)!");
            }
        }
    }

    public double TemperatureFahrenheit
    {
        get
        {
            return (_temperatureCelsius * 9 / 5) + 32;
        }
    }
}

public class Program
{
    static void Main()
    {
        var t = new Thermometer();
        t.TemperatureCelsius = 25;
        Console.WriteLine(t.TemperatureFahrenheit); // 77
    }
}
