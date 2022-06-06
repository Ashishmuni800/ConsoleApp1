using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Extension
    {
        public static void Remove(this Service s, int a,int b)
        {
            int c = a - b;
            Console.WriteLine(c);
        }

        public static void PrintPatern(this Service s, int num)
        {
            for(int i=1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
