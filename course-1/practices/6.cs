using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;

        Console.Write("Введите оценку ученика: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out grade))
        {
            Console.WriteLine("Ошибка ввода. Нужно ввести целое число.");
            return;
        }

        if (grade < 3)
            Console.WriteLine("Неудовлетворительно");
        else if (grade == 3)
            Console.WriteLine("Удовлетворительно");
        else if (grade == 4)
            Console.WriteLine("Хорошо");
        else if (grade == 5)
            Console.WriteLine("Отлично");
        else
            Console.WriteLine("Некорректная оценка");
    }
}
