using System;

namespace DZ_Tree
{
    class Diagonal
    {
        public void SolutionOne()
        {
            int[,] DoubleArray = new int[3,3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };
            Console.Write($"{DoubleArray[0,0]}{DoubleArray[1, 1]}{DoubleArray[2, 2]}");
            Console.ReadKey();
        }
    }
}
