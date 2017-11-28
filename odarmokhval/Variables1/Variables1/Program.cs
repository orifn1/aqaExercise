using System;

namespace Variables1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            //Console.WriteLine("х equel " + х);
            x = -1 + 3 * 5;            
            Console.Write("x = -1 + 3 * 5 = ");
            Console.WriteLine(x);


            x = (24 + 5) % 7;
            Console.Write("x = (24 + 5) mod 7 = ");
            Console.WriteLine(x);

            x = 15 + -4 * 6 / 11;
            Console.Write("x = 15 + -4 * 6 / 11 =  ");
            Console.WriteLine(x);

            x = 2 + 10 / 6 * 1 - 7 % 2;
            Console.Write("x = 2 + 10 / 6 * 1 - 7 mod 2 =  ");
            Console.WriteLine(x);            
            Console.ReadKey();
        }

    }
}
