using System;

public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Square : Shape
{
    public double Side { get; set; }

    public override double GetArea()
    {
        return Side * Side;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double GetArea()
    {
        return Width * Height;
    }
}

public class Program
{
    static void Main()
    {
        Shape[] shapes =
        {
            new Circle { Radius = 5 },
            new Square { Side = 4 },
            new Rectangle { Width = 3, Height = 6 }
        };
        foreach (var s in shapes)
        {
            Console.WriteLine(Math.Round(s.GetArea(), 1));
        }
    }
}

