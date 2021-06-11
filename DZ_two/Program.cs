using System;

namespace DZ_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Первое задание (Температура)
            Min_and_Max_Temperature one = new Min_and_Max_Temperature();
            one.Temerature();
            #endregion

            #region Второе задание (Порядковый номер месяца)
            MonthNumber two = new MonthNumber();
            two.Month();
            #endregion

            #region Третье задание (Четное число)
            EvenNumber tree = new EvenNumber();
            tree.Even_solution();
            #endregion

            #region Четвертое задание (Чек)
            Check four = new Check();
            four.CheckDraw();
            #endregion

            #region Пятое задание (Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима»)
            TemperatureInMonth five = new TemperatureInMonth();
            five.SeasonsSolution();
            #endregion

            #region Шестое задание (Закрепления битовых масок)
            BitMasks Six = new BitMasks();
            Six.BitMasksSolution();
            #endregion
        }
    }
}
