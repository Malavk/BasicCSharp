using System;
using System.Configuration;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace DZ_eight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConfigurationManager.AppSettings["Greetings"]);

            Console.WriteLine("Введите ваше имя: ");
            string name  = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст: ");
            string age = Console.ReadLine();

            Console.WriteLine("Введите ваш род деятельности: ");
            string job = Console.ReadLine();

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add("Username", name);
            config.AppSettings.Settings.Add("Age", age);
            config.AppSettings.Settings.Add("Job", job);
            config.Save();

            Console.WriteLine(ConfigurationManager.AppSettings["Username"]);
            Console.WriteLine(ConfigurationManager.AppSettings["Age"]);
            Console.WriteLine(ConfigurationManager.AppSettings["Job"]);
        }
    }
}


