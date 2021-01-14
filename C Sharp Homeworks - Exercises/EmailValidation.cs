using C_Sharp_Homeworks___Exercises_INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Homeworks___Exercises
{
    class EmailValidation : IEmailValidation
    {
        public bool IsStringEmail(string input)
        {
            if (input.Contains("@") && input.Contains("com") && input.Contains("."))
            {
                int indexOfAt = input.IndexOf('@');
                int indexOfCom = input.IndexOf("com");

                string beforeAtSign = input.Substring(0, indexOfAt);
                string beforeComString = input.Substring(indexOfCom-1, 1);

                if (beforeComString.Equals(".") && !beforeAtSign.Equals(String.Empty))
                {
                    return true;
                }
                else
                    return false;
            }
            else
                    return false;
        }
    }
}
