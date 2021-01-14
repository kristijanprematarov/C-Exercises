using C_Sharp_Homeworks___Exercises_INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Homeworks___Exercises
{
    class CountOnesBinary : ICountOnesBinary
    {
        public int BitsCount(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n &= (n - 1);
            }
            return count;
        }
    }
}
