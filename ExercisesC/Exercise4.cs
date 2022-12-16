using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesC
{
    public class Exercise4
    {
        public static void Pascal()
        {
            Console.WriteLine("Enter a few words, each separated by a space: ");

            string initialInput = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(initialInput))
            {
                Console.WriteLine(initialInput);

                string lower = initialInput.ToLower();
                string upper = initialInput.ToUpper();
                string[] wordsLower = lower.Split(' ');
                string[] wordsUpper = upper.Split(' ');

                int count = 0;

                foreach (string word in wordsLower)
                {

                    string end = word.Substring(1, word.Length - 1);
                    string first = wordsUpper[count].Substring(0, 1);

                    Console.Write(first + end);
                    count++;
                }

                Console.WriteLine("");
            }
        }
    }
}
