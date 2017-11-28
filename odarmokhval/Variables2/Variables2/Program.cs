using System;

namespace Variables2
{
    class Variables2
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("enter x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter y: ");
            y = int.Parse(Console.ReadLine());
            z = x + y;
            Console.WriteLine("x+y: ");
            Console.WriteLine(z);

            z = x - y;
            Console.WriteLine("x-y: ");
            Console.WriteLine(z);

            z = x * y;
            Console.WriteLine("x*y: ");
            Console.WriteLine(z);

            z = x / y;
            Console.WriteLine("x/y: ");
            Console.WriteLine(z);

            z = x * y;
            Console.WriteLine("x*y: ");
            Console.WriteLine(z);

            z = x % y;
            Console.WriteLine("x mod y: ");
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}