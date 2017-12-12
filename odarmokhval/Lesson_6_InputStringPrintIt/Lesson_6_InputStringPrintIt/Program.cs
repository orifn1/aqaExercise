using System;


namespace Lesson_6_InputStringPrintIt
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            Console.WriteLine("The string you entered is : " + str);
            Console.ReadKey();
        }
    }
}
