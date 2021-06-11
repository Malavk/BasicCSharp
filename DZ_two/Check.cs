using System;

namespace DZ_Two
{
    class Check
    {
        public void CheckDraw()
        {
            byte AZS = 35;
            string number_with_null = AZS.ToString("D4");

            byte Cassa = 4;
            string cassa_with_null = Cassa.ToString("D4");

            int OperatorCase = 354;
            string OC = OperatorCase.ToString("D4");

            double Summa = 1365.00f;
            string Sum = Summa.ToString("F2");

            double Nalichnie = 1500.00f;
            string Cash = Nalichnie.ToString("F2");

            double Change = 135.00f;
            string Ch = Change.ToString("F2");

            DateTime checkTime = new DateTime(2007, 09, 10, 18, 57, 00);
            string date = checkTime.ToString("dd.MM.yy");
            string time = checkTime.ToString("HH:mm:ss");

            Console.WriteLine($"АЗС {number_with_null} КАССА {cassa_with_null} ОПЕРАТОР {OC}\n" +
                $"ИНН ОРГ. - ПРОДАВЦА    7700000000\n" +
                $"ДТ            N 23:2516         {Sum}\n" +
                $"--------------------------------------------\n" +
                $"ИТОГО                           {Sum}\n" +
                $"--------------------------------------------\n" +
                $"Рубль России                    {Sum}\n" +
                $"Наличными                       {Cash}\n" +
                $"Сдача                            {Ch}-\n" +
                $"ЭКЛЗ 3297258661\n" +
                $"               СПАСИБО\n" +
                $"              ЗА ПОКУПКУ\n" +
                $"ЧЕК 0924      {date}         {time}\n" +
                $"фИКСАЛЬНЫЙ РЕЖИМ     82143979");
            Console.ReadKey();
        }
    }
}
