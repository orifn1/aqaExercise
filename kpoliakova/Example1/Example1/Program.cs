using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = -1 + (3 * 5);
            Console.WriteLine("x = -1 + 3 * 5=");
            Console.WriteLine(x);
            Console.ReadKey();

            x = (24 + 5) % 7;
            Console.Write("x = (24+5)%7 ="+x);
            Console.ReadKey();

            x = 15+(-4*6/11);
            Console.Write("x = 15+-4*6/11 =" + x);
            Console.ReadKey();

            x = 2+10/6*1-7%2;
            Console.Write("x = 2+10/6*1-7%2 =" + x);
            Console.ReadKey();
        }
    }
}
