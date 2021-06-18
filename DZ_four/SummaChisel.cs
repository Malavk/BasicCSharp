using System;
using System.Linq;

namespace DZ_four
{
    class SummaChisel
    {
        public int Summa(string numbers)
        {
            Console.WriteLine("Введите числа через пробел: ");
            numbers = Console.ReadLine();
            int summ = 0;

           for(int i = 0; i < numbers.Length; i++)
            {
               summ = numbers.Split(' ').Sum(int.Parse);
            }
            return summ;
        }
    }
}

