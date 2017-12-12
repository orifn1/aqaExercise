using System;

namespace Variables2
{
    class Variables2
    {
        static void Main()
        {
            int x, y, z;
            Console.WriteLine("Enter a number: 12");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: 3");
            y = int.Parse(Console.ReadLine());
            z = x + y;
            Console.WriteLine("z = x + y = " + z);

            z = x - y;
            Console.WriteLine("z = x - y = " + z);

            z = x * y;
            Console.WriteLine("z = x * y = " + z);

            z = x / y;
            Console.WriteLine("z = x / y = " + z);

            z = x % y;
            Console.WriteLine("z = x % y = " + z);

            Console.ReadKey();
        }
    }
}

