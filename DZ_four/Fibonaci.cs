using System;

namespace DZ_four
{
    class Fibonaci
    {
        public int Fi(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else
            {
                return Fi(number - 1) + Fi(number - 2);
            }
        }
    }
}
