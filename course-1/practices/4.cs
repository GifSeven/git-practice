using System;

class Program
{
    static void Main()
    {
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("Число положительное");
        }
        else if (number < 0)
        {
            Console.WriteLine("Число отрицательное");
        }
        else if (number == 0)
        {
            Console.WriteLine("Число равно нулю");
        }
    }
}
