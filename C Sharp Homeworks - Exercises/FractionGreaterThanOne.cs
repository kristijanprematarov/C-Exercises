using C_Sharp_Homeworks___Exercises_INTERFACES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace C_Sharp_Homeworks___Exercises
{
    class FractionGreaterThanOne : IFractionGreaterThanOne
    {
        public bool GreaterThanOne(string fraction)
        {
            DataTable dataTable = new DataTable();
            object resultObject = dataTable.Compute(fraction,null);
            double result = Convert.ToDouble(resultObject);
            Console.WriteLine(result);
            if (result > 1)
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
