using System;

namespace DZ_Two
{
    class MonthNumber
    {
        /*enum Seasons
        {
            Winter,
            Autumn,
            Summer,
            Spring
        }*/
        public int Month()
        {
            /*Seasons cold = Seasons.Winter;
            Seasons blossom = Seasons.Autumn;
            Seasons warm = Seasons.Summer;
            Seasons slush = Seasons.Spring;*/

            Console.WriteLine("Введите порядковый номер месяца: ");
            string number = Console.ReadLine();
            int CNum = Convert.ToInt32(number);

            string TitleOfMonth = "";

            switch (CNum)
            {
                case 1:
                    TitleOfMonth = "January";
                    break;
                case 2:
                    TitleOfMonth = "February";
                    break;
                case 3:
                    TitleOfMonth = "March";
                    break;
                case 4:
                    TitleOfMonth = "April";
                    break;
                case 5:
                    TitleOfMonth = "May";
                    break;
                case 6:
                    TitleOfMonth = "June";
                    break;
                case 7:
                    TitleOfMonth = "July";
                    break;
                case 8:
                    TitleOfMonth = "August";
                    break;
                case 9:
                    TitleOfMonth = "September";
                    break;
                case 10:
                    TitleOfMonth = "October";
                    break;
                case 11:
                    TitleOfMonth = "November";
                    break;
                case 12:
                    TitleOfMonth = "December";
                    break;
                default:
                    Console.WriteLine("Существует всего 12 месяцев =)");
                    break;
            }

            Console.WriteLine($"Вы выбрали номер {CNum}, месяц {TitleOfMonth}");
            Console.ReadKey();

            return CNum;
        }
    }
}
