using C_Sharp_Homeworks___Exercises_INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Homeworks___Exercises
{
    class PositiveCountNegativeSum : IPositiveCountNegativeSum
    {
        public int[] PosCountNegSum(string posNegNumbers)
        {
            string[] posNegNumbersArray = posNegNumbers.Split(",");
            int[] posNegNumbersArrayInt = Array.ConvertAll(posNegNumbersArray, int.Parse);
            List<int> listaPosInt = new List<int>();
            List<int> listaNegInt = new List<int>();
            for (int i = 0; i < posNegNumbersArrayInt.Length; i++)
            {
                if (posNegNumbersArrayInt[i] >= 0)
                {
                    listaPosInt.Add(posNegNumbersArrayInt[i]);
                }
                else
                    listaNegInt.Add(posNegNumbersArrayInt[i]);
            }
            int numOfPos = listaPosInt.Count;
            int sumOfNeg = listaNegInt.Sum();

            return new int[2] {numOfPos,sumOfNeg};
        }
    }
}
