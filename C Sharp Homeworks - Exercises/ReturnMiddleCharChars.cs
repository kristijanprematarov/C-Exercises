using C_Sharp_Homeworks___Exercises_INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Homeworks___Exercises
{
    class ReturnMiddleCharChars : IReturnMiddleCharChars
    {
        public string ReturnMidCharChars(string theString)
        {
            int stringLength = theString.Length;
            if (stringLength % 2 == 0)
            {
                int middleEven = stringLength / 2;
                string middleChars = theString.Substring(middleEven - 1, 2);
                
                return middleChars;
            }
            else
            {
                int middleOdd = stringLength / 2;
                string middleChar = theString.Substring(middleOdd,1);

                return middleChar; ;
            }

        }
    }
}
