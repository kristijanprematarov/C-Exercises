using C_Sharp_Homeworks___Exercises_INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Homeworks___Exercises
{
    class ReturnStringArray : IReturnStringArray
    {
        public string[] ReturnTheStringArray()
        {
            List<object> lista = new List<object>();

            while (true)
            {
                string vlez = Console.ReadLine();

                string vlezString = vlez;
                int vlezInt;

                bool isConvertableToInt = int.TryParse(vlez, out vlezInt);

                if (!vlez.Equals("exitNow") && isConvertableToInt.Equals(true))
                {
                    lista.Add(vlezInt);
                }
                else if (!vlez.Equals("exitNow"))
                {
                    lista.Add(vlezString);
                }
                else
                    break;
            }
            Console.WriteLine(AppStrings.DelimiterLine);

            bool isListEmpty = lista.Any();

            if (isListEmpty.Equals(true))
            {
                object[] objectArray = lista.ToArray();
                Console.WriteLine("Members in the array and their type:");

                foreach (var item in objectArray)
                {
                    Console.WriteLine(item + "  " + item.GetType());
                }

                Console.WriteLine(AppStrings.DelimiterLine);

                string[] stringArray = Array.ConvertAll(objectArray, Convert.ToString);

                return stringArray;
            }
            else
                return new string[] { };
        }
    }
}
