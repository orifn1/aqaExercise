﻿using System;


namespace Lesson_4_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int n = x.ToString().Length;

            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0}{1}{0}", x, new String(' ', n));
            Console.WriteLine("{0}{1}{0}", x, new String(' ', n));
            Console.WriteLine("{0}{1}{0}", x, new String(' ', n));
            Console.WriteLine("{0}{0}{0}", x);

            Console.ReadKey();
        }
    }
}