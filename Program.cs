using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<object> newList = new List<object>();
            newList.Add(7);
            newList.Add(28);
            newList.Add(-1);
            newList.Add(true);
            newList.Add("chair");
            int newSum  = 0;
            for (int i = 0; i < newList.Count; i++){
                if (newList[i] is int) {
                    Console.WriteLine(newList[i]);
                    newSum = newSum + (int)newList[i];
                }
                if (newList[i] is string) {
                    Console.WriteLine(newList[i]);
                }
                if (newList[i] is bool) {
                    Console.WriteLine(newList[i]);
                }
            }
            Console.WriteLine(newSum);
        }
    }
}
