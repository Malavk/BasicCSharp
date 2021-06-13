using System;

namespace DZ_Tree
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            #region'Написать программу, выводящую элементы двухмерного массива по диагонали.
            Diagonal one = new Diagonal();
            one.SolutionOne();
            #endregion

            #region'Телефонный справочник
            Phonebook two = new Phonebook();
            two.PhonebookSolution();
            #endregion

            #region'Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
            olleH tree = new olleH();
            tree.olleHSolution();
            #endregion

            #region'Морской бой
            SeaBattle four = new SeaBattle();
            four.SeaBattleSolution();
            #endregion
        }
    }
}
