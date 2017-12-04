using System;


namespace Lesson_7_CountVowelConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            string z;
            int vowel, consonant, i, max;

            Console.Write("input a string with lower and upper letters: \n");
            
            z = Console.ReadLine();

            vowel = 0;
            consonant = 0;
            max = z.Length;

            for (i = 0; i < max; i++)

            {
                if (z[i] == 'a' || z[i] == 'e' || z[i] == 'i' || z[i] == 'o' || z[i] == 'u' || z[i] == 'y'
                  || z[i] == 'A' || z[i] == 'E' || z[i] == 'I' || z[i] == 'O' || z[i] == 'U' || z[i] == 'Y')
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
