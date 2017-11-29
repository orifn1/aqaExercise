using System;


namespace Lesson_3_AverageVar2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter the x{0} number: ", i);
                x[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            var z = (x[0] + x[1] + x[2] + x[3]) / 4;

            Console.WriteLine("Average value is equal to: {0:0}", z);

            Console.ReadKey();
        }
    }
}
