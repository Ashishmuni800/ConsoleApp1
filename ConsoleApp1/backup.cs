using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class backup
    {

        //int p1 = 0, p2 = 1, p3;
        //Console.WriteLine("print fibonacci number input  here");
        //int count = int.Parse(Console.ReadLine());
        //Console.Write(p1 + " " + p2);
        //for (int i = 2; i < count; i++)
        //{
        //    p3 = p1 + p2;
        //    Console.Write(" " + p3);

        //    p1 = p2;
        //    p2 = p3;
        //}

        //for(int i = 1; i <= 5; i++)
        //{
        //    for(int j = 1; j <= 5; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //for (int i = 5; i >= 1; i--)
        //{
        //    for (int j = 1; j < i; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int k = 5; k >= i; k--)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //for (int i = 5; i>=1; i--)
        //{
        //    for (int j = 1; j<i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //for (int i = 5; i >= 1; i--)
        //{
        //    for (int j = 5; j > i; j--)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int k = 1; k <= i; k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int j = i; j < 5; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int k = 1; k < (i * 2); k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //int x, y, z;
        //for (x = 5; x >= 1; x--)
        //{
        //    for (y = 5; y > x; y--)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (z = 1; z < (x * 2); z++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //int[] frequency = new int[255];
        //int i = 0, max, l;
        //int ascii;

        //Console.WriteLine("Enter your string : ");
        //string str = Console.ReadLine();
        //l = str.Length;
        //for(i=0; i < 255; i++)
        //{
        //    frequency[i] = 0;
        //}
        //i = 0;
        //while (i < l)
        //{
        //    ascii = (int)str[i];
        //    frequency[ascii] += l;
        //    i++;
        //}
        //max = 0;
        //for (i = 0; i < 255; i++)
        //{
        //    if (i != 32)
        //    {
        //        if (frequency[i] > frequency[max])
        //            max = i;
        //    }
        //}
        //Console.WriteLine("The Highest frequency of character '{0}' is appearing for number of times : {1} \n\n", (char)max, frequency[max]);

        //int num;
        //Program p = new Program();
        //Console.WriteLine("Enter a decimale number: ");
        //num = int.Parse(Console.ReadLine());
        //Console.Write("the binary equivalent num of is: ");
        //p.BinaryConversion(num);

        //string strtwo;
        //Console.Write("Please Enter a string : ");
        //strtwo = Console.ReadLine();
        //Console.WriteLine("\"" + strtwo + "\"" + " contains {0} spaces", Countspace(strtwo));

        //Console.WriteLine("Enter any number");
        //int number = int.Parse(Console.ReadLine());
        //CheckOddEven(number);

        //int number;
        //Console.Write("Enter a number: ");
        //number = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("The sum of the digits of the number {0} is : {1} \n", number, CalSum(number));


        //Console.WriteLine("Enter your number");
        //int n = int.Parse(Console.ReadLine());
        //if (CheckPrime(n))
        //{
        //    Console.WriteLine(n+" is prime");
        //}
        //else
        //{
        //    Console.WriteLine(n+" is not prime");
        //}

        //Console.WriteLine("Enter the number ");
        //int num = int.Parse(Console.ReadLine());
        //Console.WriteLine("The Fibonacci series of " + num + " numbers is :");
        //for (int i = 0; i < num; i++)
        //{
        //    Console.Write(Fibonachi(i) + " ");
        //}

        //decimal fact;
        //Console.WriteLine("Eneter the number ");
        //int num = int.Parse(Console.ReadLine());
        //fact = Factorials(num);
        //Console.WriteLine("The factorial of number {0} is  {1}", num, fact);

        //string username, password;
        //int ctr = 0;
        //do
        //{
        //    Console.Write("Input a username: ");
        //    username = Console.ReadLine();

        //    Console.Write("Input a password: ");
        //    password = Console.ReadLine();

        //    if (username != "abcd" || password != "1234")
        //        ctr++;
        //    else
        //        ctr = 1;

        //}
        //while ((username != "admin" || password != "123456") && (ctr != 3));

        //if (ctr == 3)
        //    Console.WriteLine("\nLogin attemp three or more times. Try later!");
        //else
        //    Console.WriteLine("\nThe password entered successfully!");

        //Console.WriteLine();

        //int num = 5;
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
        //    Console.WriteLine("Prime number : "+num);
        //}
        //else
        //{
        //    Console.WriteLine("number is not prime : "+num);
        //}

        //int num = 121;
        //int result = 0;
        //int rem;
        //int temp = num;
        //while (num != 0)
        //{
        //    rem = num % 10;
        //    result = result * 10 + rem;
        //    num = num / 10;
        //}
        //num = temp;
        //if (num == result)
        //{
        //    Console.WriteLine("palindrom number");
        //}
        //else
        //{
        //    Console.WriteLine("not pelindrom number");
        //}

        ////m=ft/3.2808
        //double meter, feet;
        //Console.WriteLine("convert to feet to meter");
        //feet = int.Parse(Console.ReadLine());
        //meter = feet / 3.2808;
        //Console.WriteLine(meter);

        //char c;
        //Console.WriteLine("Enter a character: ");
        //c = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine("\nASCII Value of " + c + " " + Convert.ToInt32(c));

        //int day, Weak, year;
        //Console.WriteLine("Enter day");
        //day = Convert.ToInt32(Console.ReadLine());
        //year = day / 365;
        //Weak = (day % 365) / 7;
        //day = day - (year * 365) + (Weak * 7);
        //Console.WriteLine(year);
        //Console.WriteLine(Weak);
        //Console.WriteLine(day);

    }
}
