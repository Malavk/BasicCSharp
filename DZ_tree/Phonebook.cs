using System;

namespace DZ_Tree
{
    class Phonebook
    {
        public void PhonebookSolution()
        {
            string[,] pb = new string[5, 2]
                { {"Олег", "8910939644 / oleg@bk.ru" }, 
                {"Владимир", "8910939655 / vladimir@bk.ru" }, 
                { "Николай", "8910939666 / nikolay@bk.ru" }, 
                { "Жанна", "8910939777 / zhanna@bk.ru" }, 
                { "Петр", "891098888 / petr@bk.ru" } };

            for (int i = 0; i < pb.GetLength(0); i++)
            {
               for (int j = 0; j < pb.GetLength(1); j++)
                    {
                        Console.WriteLine(pb[i,j]);
                        Console.ReadKey();
                    }
            }
        }
    }
}
