using System;

public abstract class Shape
{

    public abstract string Name { get; }


    public abstract double GetArea();


    public void Print()
    {
        Console.WriteLine($"{Name}: площадь = {GetArea()}");
    }
}

public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override string Name => "Circle";
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double Width;
    private double Height;
    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }
    public override string Name => "Rectangle ";
    public override double GetArea()
    {
        return Width * Height;
    }
}
    public class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        circle.Print(); 
        rectangle.Print(); 
    }
}