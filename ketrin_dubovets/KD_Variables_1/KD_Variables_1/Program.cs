using System;

namespace KD_Variables_1
{
    class Variables1
    {
        static void Main()
        {
            //-1 + 3 * 5
            int x;
            x = -1 + 3 * 5;
            Console.WriteLine("х = -1 + 3 * 5 = " + x);

            //(24+5) % 7
            int y;
            y = (24 + 5) % 7;
            Console.WriteLine("y = (24 + 5) % 7 = " + y);

            //15 + -4*6 / 11
            int z;
            z = 15 + -4 * 6 / 11;
            Console.WriteLine("z = 15 + -4 * 6 / 11 = " + z);

            //2 + 10 / 6 * 1 - 7 % 2
            int q;
            q = 2 + 10 / 6 * 1 - 7 % 2;
            Console.WriteLine("q = 2 + 10 / 6 * 1 - 7 % 2 = " + q);
        }
    }
}



