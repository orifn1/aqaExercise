using System;


namespace Lesson_5_InputString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int x;
            x = 0;

            Console.Write("Enter the characters you want to reverse: ");
            str = Console.ReadLine();

            x = str.Length - 1;
            Console.Write("The characters in reverse order:  ");
            while (x >= 0)
            {
                Console.Write("{0} ", str[x]);
                x--;

            }
                Console.ReadKey();
        }
    }
}
