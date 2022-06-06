using System;
using System.Text;
using System.Collections.Generic;
using BusinessLayer.Models;
using BusinessLayer.Polymore;

namespace ConsoleApp1
{
    class Program:Write
    {
        public int BinaryConversion(int num)
        {
            int bin;
            if(num != 0)
            {
                bin = (num % 2) + 10 * BinaryConversion(num / 2);
                Console.Write(bin);
                return 0;
            }
            else
            {
                return 0;
            }
        }

        public static int Countspace(string str)
        {
            int spcctr = 0;
            string strone;
            for(int i = 0; i < str.Length; i++)
            {
                strone = str.Substring(i, 1);
                if(strone==" ")
                {
                    spcctr++;
                }
            }
            return spcctr;
        }

        public static int CalSum(int num)
        {
            string n1 = Convert.ToString(num);
            int sum = 0;
            for(int i = 0; i < n1.Length; i++)
            {
                sum += Convert.ToInt32(n1.Substring(i, 1));
            }
            return sum;
        }

        public static void CheckOddEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number : "+num);
            }
            else
            {
                Console.WriteLine("Odd number : "+num);
            }
        }

        public static bool CheckPrime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        public static int Fibonachi(int number)
        {
            int num1 = 0;
            int num2 = 1;
            for(int i = 0; i < number; i++)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }
            return num1;
        }
        public static decimal Factorials(int n1)
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
        public static void Great()
        {
            Console.WriteLine("Good morning !");
        }
            public static void Great(string name)
        {
            Console.WriteLine("Good morning "+name);
        }

        public static void PassByRef(ref int a)
        {
            a = a + 10;
            Console.WriteLine(a);
        }
        public static void PassByOut(out int b)
        {
            b =10;
            Console.WriteLine(b);
        }
        
        public static string Replace(string ch,int count)
        {
            string rep = string.Empty;
            for(int i = 0; i <= count; i++)
            {
                rep += ch;
            }
            return rep;
        }

        static void Main(string[] args)
        {
            
            //Emp e = new Emp();
            //e.StringReverse("ashish");
            //Console.WriteLine(e.Factorials(5));

            //int[] arr = new int[12] { 2, 4, 6, 8, 8, 3, 5, 9, 2, 5, 7, 3 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);
            //foreach (int item in arr)
            //{
            //    sum += item;
            //}
            //Console.WriteLine(sum);

            //Console.WriteLine("Enter Your Email");
            //string str = Console.ReadLine();
            //string email = str.Substring(0, str.IndexOf("@"));
            //string username = str.Substring(0, 3);

            //string em = username + Replace("*", str.Length - 3) + str.Substring(str.IndexOf("@"));
            //Console.WriteLine(em);

            //Console.WriteLine("Enter Your Mobile number");
            //string mo =Console.ReadLine();
            //string mobile = Replace("*", mo.Length - 3) + mo.Substring(7);
            //Console.WriteLine(mobile);

            //List<int> data = new List<int>();
            //data.Add(23);
            //data.Add(25);
            //data.Add(33);
            //data.Add(12);
            //data.Add(19);

            //IEnumerable<int> e = (IEnumerable<int>)data;

            //foreach (var item in e)
            //{
            //    Console.WriteLine(item);
            //}

            //IEnumerator<int> innumrate = data.GetEnumerator();
            //while (innumrate.MoveNext())
            //{
            //    Console.WriteLine(innumrate.Current.ToString());
            //}

            //int num = 8;
            //int count = 0;
            //for(int i = 1; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        count++;
            //    }
            //}
            //if (count == 2)
            //{
            //    Console.WriteLine("Prime number");
            //}
            //else
            //{
            //    Console.WriteLine("not a prime number");
            //}

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int count = 1;
            //int number = 5;
            //count = number - 1;
            //for (int j = 1; j <= 5; j++)
            //{
            //    #region Printing Space  
            //    for (int i = 1; i <= count; i++)
            //        Console.Write(" ");
            //    count--;
            //    #endregion
            //    for (int i = 1; i <= 2 * j - 1; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}


            //Great();
            //for (int a = 1; a <= 5; a++)
            //{
            //    for (int b = 1; b < a; b++)
            //    {
            //        Console.Write(b);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("----------------------------------");
            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("----------------------------");
            //int n = 8;
            //for (int i = 0; i < n; ++i)
            //{
            //    Stars(i + 1);
            //    Spaces(n - i - 1);
            //    Stars(n - i + 1);
            //    Spaces(2 * i);
            //    Stars(n - i);
            //    Spaces(n - i - 1);
            //    Stars(i + 1);

            //    Console.WriteLine();
            //}
            Console.ReadLine();
        }
        private static void Stars(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write("*");
        }
        private static void Spaces(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write(" ");
        }
    }
}
