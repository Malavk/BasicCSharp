using System;
using System.IO;

namespace DZ_five
{
    class Timetxt
    {
        public void SaveTime()
        {
            string filename = "startup.txt";
            File.WriteAllText(filename, $"Время сейчас: {DateTime.Now}");

            string filetext = File.ReadAllText(filename);
            Console.WriteLine(filetext);
            Console.ReadLine();
        }
    }
}
