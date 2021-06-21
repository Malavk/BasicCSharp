using System;
using System.IO;

namespace DZ_five
{
    class BinNumber
    {
        public void BinSave()
        {
            string filename = "bytes.bin";

            Console.WriteLine("Введите любые числа: ");
            string BinNumber = Console.ReadLine();
            byte[] byteArr = System.Text.Encoding.UTF8.GetBytes(BinNumber);
            File.WriteAllBytes(filename, byteArr);

            byte[] fromFile = File.ReadAllBytes(filename);
            Console.WriteLine(fromFile);
            Console.ReadLine();
            

        }
    }
}
