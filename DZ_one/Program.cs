using System;

namespace DZ_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как тебя зовут?");
            string name = Console.ReadLine();

            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");
            Console.ReadKey();
        }
    }
}
