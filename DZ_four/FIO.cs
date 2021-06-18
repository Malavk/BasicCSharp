using System;

namespace DZ_four
{
    class FIO
    {
        public string FullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }

        public void WriteMethod()
        {
            Console.WriteLine(FullName("Oleg", "Ermoshchikov", "Vladimirivich"));
            Console.WriteLine(FullName("Ilya", "Egorov", "Alexandrovich"));
            Console.WriteLine(FullName("Olga", "Ivanova", "Sergeevna"));
            Console.ReadLine();
        }
    }
}
