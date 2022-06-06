using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Polymore
{
    public class Write
    {
        public static void Print(string words)
        {
            Console.Write(words);
        }
        public static void Print(int words)
        {
            Console.Write(words);
        }
        public static void Print(char words)
        {
            Console.Write(words);
        }
        public static void Print(float words)
        {
            Console.Write(words);
        }
        public static void Print(decimal words)
        {
            Console.Write(words);
        }
        public static void Print(bool value)
        {
            Console.Write(value);
        }

        public static void Println(string words)
        {
            Console.WriteLine(words);
        }
        public static void Println(int words)
        {
            Console.WriteLine(words);
        }
        public static void Println(char words)
        {
            Console.WriteLine(words);
        }
        public static void Println(float words)
        {
            Console.WriteLine(words);
        }
        public static void Println(decimal words)
        {
            Console.WriteLine(words);
        }
        public static void Println()
        {
            Console.WriteLine();
        }
    }
}
