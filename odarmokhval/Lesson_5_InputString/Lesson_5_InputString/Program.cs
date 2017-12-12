using System;

namespace Lesson_5_InputString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the characters you want to reverse: ");
            string str = Console.ReadLine();

            int x = str.Length;
            Console.Write("The characters in reverse order:  ");
            while (--x >= 0)
            {
                Console.Write("{0} ", str[x]);
            }

            Console.ReadKey();
        }
    }
}
