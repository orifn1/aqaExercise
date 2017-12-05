using System;


namespace Lesson_7_CountVowelConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a string with lower and upper letters: \n");

            string z = Console.ReadLine();

            int vowel = 0;
            int consonant = 0;

            for (int i = 0; i < z.Length; i++)
            {
                if ("aeiouyAEIOUY".IndexOf(z[i]) != -1)
                {
                    vowel++;
                }

                else if
                (z[i] == 'b' || z[i] == 'c' || z[i] == 'd' || z[i] == 'f' || z[i] == 'g' || z[i] == 'h' || z[i] == 'j' || z[i] == 'k'

                || z[i] == 'l' || z[i] == 'm' || z[i] == 'n' || z[i] == 'p' || z[i] == 'q' || z[i] == 'r' || z[i] == 's' || z[i] == 't'
                || z[i] == 'v' || z[i] == 'w' || z[i] == 'x' || z[i] == 'z'

                || z[i] == 'B' || z[i] == 'C' || z[i] == 'D' || z[i] == 'F' || z[i] == 'G' || z[i] == 'H' || z[i] == 'J' || z[i] == 'K'

                || z[i] == 'L' || z[i] == 'M' || z[i] == 'N' || z[i] == 'P' || z[i] == 'Q' || z[i] == 'R' || z[i] == 'S' || z[i] == 'T'
                || z[i] == 'V' || z[i] == 'W' || z[i] == 'X' || z[i] == 'Z')

                {
                    consonant++;
                }
            }

                Console.Write("The total number of vowel in the string is : {0}\n", vowel);
                Console.Write("The total number of consonant in the string is : {0}\n", consonant);

                Console.ReadKey();
            }
        }
    }
