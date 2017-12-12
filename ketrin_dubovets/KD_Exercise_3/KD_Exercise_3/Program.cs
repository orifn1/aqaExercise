using System;

namespace Variables2
{
    class Variables3
    {
        static void Main()
        {
            int x1, x2, x3, x4;
            Console.WriteLine("Enter the First number: 10");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number: 15");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: 20");
            x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the four number: 30");
            x4 = int.Parse(Console.ReadLine());

            int average = (x1 + x2 + x3 + x4) / 4;
            Console.WriteLine("Average = " + average);

            Console.ReadKey();
        }
    }
}

