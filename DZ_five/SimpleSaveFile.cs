using System;
using System.IO;

namespace DZ_five
{
    class SimpleSaveFile
    {
        public void FileSave()
        {
            string filename = "text.txt";
            Console.WriteLine("Напишите любой текст для сохранений в файл: ");
            string textType = Console.ReadLine();

            File.WriteAllText(filename, textType);
        }
    }
}
