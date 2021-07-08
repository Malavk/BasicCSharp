using System;

namespace DZ_Tree
{
    class SeaBattle
    {
        public void SeaBattleSolution()
        {
            char[,] arr = new char[10, 10] { { 'o', 'x', 'x', 'x', 'x', 'o', 'x', 'x', 'o', 'o' },
                                             { 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o' },
                                             { 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o' },
                                             { 'x', 'x', 'x', 'o', 'o', 'o', 'o', 'o', 'o', 'o' },
                                             { 'o', 'o', 'o', 'o', 'x', 'o', 'o', 'x', 'x', 'o' },
                                             { 'o', 'o', 'o', 'o', 'x', 'o', 'o', 'o', 'o', 'o' },
                                             { 'o', 'o', 'o', 'o', 'x', 'o', 'o', 'o', 'o', 'o' },
                                             { 'x', 'x', 'o', 'o', 'x', 'o', 'o', 'o', 'o', 'x' },
                                             { 'o', 'o', 'o', 'o', 'o', 'o', 'x', 'o', 'o', 'x' },
                                             { 'o', 'o', 'o', 'o', 'o', 'o', 'x', 'o', 'o', 'x' }};

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write($" {arr[i, j]}");
            }
                    Console.ReadKey();
        }
    }
}
