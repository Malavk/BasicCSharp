using System;

namespace DZ_four
{
    class TimeOfTheYear
    {
        public Enumiration WhitchMonth(int NumberOfMunth)
        {
            if(NumberOfMunth < 0 || NumberOfMunth > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                Console.ReadLine();
            }
            else
            {
                switch ((NumberOfMunth % 12) / 3)
                {
                    case 0:
                        return Enumiration.Winter;
                    case 1:
                        return Enumiration.Spring;
                    case 2:
                        return Enumiration.Summer;
                    default:
                        return Enumiration.Autumn;
                }
            }
            return Enumiration.NOSeason;
        }
        public string Season(Enumiration EnumNumber)
        {
            switch (EnumNumber)
            {
                case Enumiration.Winter:
                    return "Зима";
                case Enumiration.Spring:
                    return "Весна";
                case Enumiration.Summer:
                    return "Лето";
                case Enumiration.Autumn:
                    return "Осень";
                default: return "";
            }
        }
        public void toWrite()
        {
            Console.WriteLine("Введите число месяца: ");
            Console.WriteLine(Season(WhitchMonth(Convert.ToInt32(Console.ReadLine()))));
            Console.ReadLine();
        }
    }
}
