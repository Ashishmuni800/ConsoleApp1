using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Models;

namespace BusinessLayer.Models
{
    public class Emp : IEmployees
    {
        public decimal Factorials(int n1)
        {
            if (n1 == 0)
            {
                return 1;
            }
            else
            {
                return n1 * Factorials(n1 - 1);
            }
        }

        public void StringReverse(string str)
        {
            string rev = string.Empty;
            for(int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            Console.WriteLine(rev);
        }
    }
}
