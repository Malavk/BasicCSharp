using System;

namespace DZ_Two
{
    
    class BitMasks
    {
        public void BitMasksSolution()
        {
            DaysOfWeek officeOne = DaysOfWeek.Tuesday | DaysOfWeek.Wednesday | DaysOfWeek.Thursday | DaysOfWeek.Friday;
            DaysOfWeek officeTwo = DaysOfWeek.Monday | DaysOfWeek.Tuesday | DaysOfWeek.Wednesday | DaysOfWeek.Thursday | DaysOfWeek.Friday | DaysOfWeek.Saturday | DaysOfWeek.Sunday;

            Console.WriteLine($"Офис номер 1 работает: {officeOne}");
            Console.ReadKey();
            Console.WriteLine($"Офис номер 2 работает: {officeTwo}");
            Console.ReadKey();
        }
    }
}
