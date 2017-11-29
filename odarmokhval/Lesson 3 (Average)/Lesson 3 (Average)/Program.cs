using System;

namespace Lesson3
{
    class Lesson3
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, x4, z;

            Console.WriteLine("Enter the First number: ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the Second number: ");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the Third number: ");
            x3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the Fourth number: ");
            x4 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            z = (x1 + x2 + x3 + x4) / 4;
            Console.WriteLine("average value is equal to: ");
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}