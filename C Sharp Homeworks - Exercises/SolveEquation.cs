using C_Sharp_Homeworks___Exercises_INTERFACES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace C_Sharp_Homeworks___Exercises
{
    class SolveEquation : ISolveEquation
    {
        public int EquationSolving(string equation)
        {
            DataTable dataTable = new DataTable();
            object resultObject = dataTable.Compute(equation, null);
            int result = Convert.ToInt32(resultObject);
            return result;
        }
    }
}
