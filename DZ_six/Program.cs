using System;
using System.Diagnostics;

namespace DZ_six
{
    class Program
    {
        static void Main(string[] args)
        {
            Process Dprocess = new Process();
            Console.WriteLine($"Список всех ваших доступных процессов\ ID: {Dprocess.Id}  Name: {Dprocess.ProcessName}");

            Console.WriteLine("Введите имя процесса которое хотите прекратить: ");
            string name = Console.ReadLine();

            foreach(Process process in Process.GetProcesses())
            {
                if (process.ProcessName.StartsWith(name))
                {
                    process.Kill();
                    process.WaitForExit();
                }
                Console.WriteLine($"Измененный список процессов исключая тот который мы прекратили\ ID: {process.Id}  Name: {process.ProcessName}");
            }
        }
    }
}
