using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> newList = new List<object>();
            newList.Add(7);
            newList.Add(28);
            newList.Add(-1);
            newList.Add(true);
            newList.Add("chair");

            foreach(var i in newList)
            {
                int num = 0;
                if(i is int)
                {
                    int j = (int)i;
                    num = num + j;
                }
                else
                {
                    Console.WriteLine($"This is the value: {i}");
                    continue;
                }
                Console.WriteLine($"This is the sum of all the values {num}");
            }
        }
    }
}
