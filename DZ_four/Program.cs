using System;

namespace DZ_four
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание №1 ФИО через метод
            FIO one = new FIO();
            one.WriteMethod();
            #endregion

            #region Задание №2 Сумма введеных чисел
            SummaChisel two = new SummaChisel();
            int s = two.Summa("");
            Console.WriteLine(s);
            Console.ReadKey();
            #endregion

            #region Задание №3 Выберете число месяца
            TimeOfTheYear three = new TimeOfTheYear();
            three.toWrite();
            #endregion

            #region Задание №4 Число Фибоначчи
            Fibonaci four = new Fibonaci();
            Console.WriteLine("Введите число: ");
            string ss = Console.ReadLine();
            int vs = Convert.ToInt32(ss);
            four.Fi(vs);
            Console.ReadLine();
            #endregion
        }
    }
}
