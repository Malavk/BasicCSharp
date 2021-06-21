using System;
using System.IO;

namespace DZ_five
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл
            SimpleSaveFile one = new SimpleSaveFile();
            one.FileSave();
            #endregion

            #region Написать программу, которая при старте дописывает текущее время в файл «startup.txt»
            Timetxt two = new Timetxt();
            two.SaveTime();
            #endregion

            #region Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл
            BinNumber three = new BinNumber();
            three.BinSave();
            #endregion
        }
    }
}
