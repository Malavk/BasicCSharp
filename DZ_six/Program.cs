using System;
using System.Diagnostics;

namespace DZ_six
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя процесса: ");
            string name = Console.ReadLine();

            foreach(Process process in Process.GetProcesses())
            {
                if (process.ProcessName.StartsWith(name))
                {
                    process.Kill();
                    process.WaitForExit();
                }
                Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
            }
        }
    }
}
