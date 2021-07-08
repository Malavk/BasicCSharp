using System;

namespace DZ_Two
{
    class Min_and_Max_Temperature
    {
        public double Temerature()
        {
            Console.WriteLine("Введите максимальную температуру: ");
            string maxss = Console.ReadLine();
            double maxsd = Convert.ToDouble(maxss);

            Console.WriteLine("Введите минимальную температуру: ");
            string minss = Console.ReadLine();
            double minsd = Convert.ToDouble(minss);

            double middleTemperature = (maxsd + minsd) / 2;

            if(maxsd < minsd)
            {
                Console.WriteLine("Максимальная температура меньше минимальной! Попробуйте заново!");
                Console.ReadKey();
                return 0;
            }

            Console.WriteLine($"Средняя температура сегодня: {middleTemperature}");
            Console.ReadKey();

            return middleTemperature;
        }
    }
}
