using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesC
{
    public class Exercise5
    {
        public static int CountVowels(string input)
        {
            int vowelCount = 0;

            if (!String.IsNullOrWhiteSpace(input))
            {
                foreach (char ch in input)
                {
                    if ((ch == 'a' || ch == 'A')
                         || (ch == 'e' || ch == 'E')
                         || (ch == 'i' || ch == 'I')
                         || (ch == 'o' || ch == 'O')
                         || (ch == 'u' || ch == 'U'))
                    {
                        vowelCount++;
                    }
                }
            }
            return vowelCount;
        }
        public static void Vowels()
        {
            Console.WriteLine("Enter any word and I will return the number of vowels in the word: ");
            string input = Console.ReadLine();

            Console.WriteLine("Number of vowels is: " + CountVowels(input));
        }
    }
}
