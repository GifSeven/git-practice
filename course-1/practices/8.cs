using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        void PrintPerson(string name, int age, string city)
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Город: {city}");

        }
        PrintPerson("Егор", 15, "Москва");
    }
}
