using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        void PrintPerson(string name, int age = 18, string hobby = "Не указано")
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Хобби: {hobby}");
        }
        PrintPerson("Вася", 19 ,"Велик");
        PrintPerson("Ваня", 10);
        PrintPerson("Никита");
    }
}
