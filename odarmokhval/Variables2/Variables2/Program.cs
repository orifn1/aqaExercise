using System;

namespace Variables2
{
    class Variables2
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = 12;
            y = 3;

            Console.WriteLine("x equals " + x);
            Console.WriteLine("y equals " + y);
            z = x + y;
            Console.WriteLine("z equals x+y:");
            Console.WriteLine (z);
            

            z = x - y;
            Console.WriteLine("z equals x-y:");
            Console.WriteLine(z);
            

            z = x * y;
            Console.WriteLine("z equals x*y:");
            Console.WriteLine(z);
            

            z = x / y;
            Console.WriteLine("z equals x/y:");
            Console.WriteLine(z);
            
            z = x % y;
            Console.WriteLine("z equals x mod y:");
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}