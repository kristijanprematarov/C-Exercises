using C_Sharp_Homeworks___Exercises_INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Homeworks___Exercises
{
    class NumberSymmetrical : INumberSymmetrical
    {
        public bool CheckIfSymmetrical(int aNumber)
        {
            int reversedNumber = 0;
            int lastDigitOfNumber = 0;
            int number = aNumber;
            while (aNumber > 0)
            {
                lastDigitOfNumber = aNumber % 10;
                reversedNumber = (reversedNumber * 10) + lastDigitOfNumber;
                aNumber /= 10;
            }

            if (reversedNumber.Equals(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
