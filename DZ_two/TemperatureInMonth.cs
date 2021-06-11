using System;

namespace DZ_Two
{
    class TemperatureInMonth
    {
        Min_and_Max_Temperature tt = new Min_and_Max_Temperature();
        MonthNumber mm = new MonthNumber();

        public void SeasonsSolution()
        {
            double temperatureofmonth = tt.Temerature();
            int soCold = mm.Month();

            if(temperatureofmonth > 0 && soCold <= 2)
            {
                Console.WriteLine("Дождливая зима");
                Console.ReadKey();
            }
            else if (temperatureofmonth > 0 && soCold == 12)
            {
                Console.WriteLine("Дождливая зима");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Снежная зима");
                Console.ReadKey();
            }
        }
    }
}
