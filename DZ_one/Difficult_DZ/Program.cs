using System;

namespace Difficult_Dz
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double x;
            double xOne;
            double xTwo;
             
            Console.Write("Введите число a: ");
            string aToConvert = Console.ReadLine();
            a = Convert.ToInt32(aToConvert);

            Console.Write("Введите число b: ");
            string bToConvert = Console.ReadLine();
            b = Convert.ToInt32(bToConvert);

            Console.Write("Введите число c: ");
            string cToConvert = Console.ReadLine();
            c = Convert.ToInt32(cToConvert);


            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant < 0)
            {
                Console.Write("Число меньше 0");
            }
            else if (discriminant == 0)
            {
                x = -b / 2 * a;
            }
            else if (discriminant > 0)
            {
                xOne = (-b + Math.Sqrt(discriminant)) / (2 * a);
                xTwo = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine($"Корень квадратного уравнения равен {xOne} и {xTwo}");
                Console.ReadKey();
            }
        }
    }
}
