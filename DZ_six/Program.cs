using System;
using System.Diagnostics;

namespace DZ_six
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Process processString in Process.GetProcesses())
            {
                Console.WriteLine($"ID: {processString.Id}  Name: {processString.ProcessName}");
            }

            Console.WriteLine("Введите имя процесса которое хотите прекратить: ");
            string name = Console.ReadLine();

            foreach(Process process in Process.GetProcesses())
            {
                if (process.ProcessName.StartsWith(name))
                {
                    process.Kill();
                    process.WaitForExit();
                }
                Console.WriteLine($"Список процессов после изменений ID: {process.Id}  Name: {process.ProcessName}");
            }
        }
    }
}
