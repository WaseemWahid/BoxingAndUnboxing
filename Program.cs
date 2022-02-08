using System;
using System.Collections.Generic;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main()
        {
            List<object> mixedList = new List<object>();
            mixedList.Add(7);
            mixedList.Add(28);
            mixedList.Add(-1);
            mixedList.Add(true);
            mixedList.Add("chair");
            int objSum = 0;
            foreach (object item in mixedList)
            {
                if (item is int)
                {
                    objSum += (int)item;
                }
                Console.WriteLine(item);
            }
            Console.WriteLine(objSum);
        }
    }
}
