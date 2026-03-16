using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите выражение (или exit): ");
            string input = Console.ReadLine();
            if (input == "exit") break;

            string[] p = input.Split(' ');
            double a = double.Parse(p[0]);
            string op = p[1];
            double b = double.Parse(p[2]);

            if (op == "+") Console.WriteLine("Результат: " + Add(a, b));
            if (op == "-") Console.WriteLine("Результат: " + Subtract(a, b));
            if (op == "*") Console.WriteLine("Результат: " + Multiply(a, b));
            if (op == "/") Console.WriteLine("Результат: " + Divide(a, b));
        }
    }

        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b; 
        static double Multiply(double a, double b) => a * b; 
        static double Divide(double a, double b) => a / b;   
} 
