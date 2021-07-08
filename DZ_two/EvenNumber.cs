using System;

namespace DZ_Two
{
    class EvenNumber
    {
        public void Even_solution()
        {
            Console.WriteLine("Введите любое число:  ");
            string number = Console.ReadLine();
            int Cnumber = Convert.ToInt32(number);

            if (Cnumber % 2 == 0)
            {
                Console.WriteLine("Вы ввели четное число!");
            }
            else
            {
                Console.WriteLine("Вы ввели нечетное число!");
            }
            Console.ReadKey();
        }
    }
}
