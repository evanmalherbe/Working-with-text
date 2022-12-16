using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesC
{
    public class Exercise3
    {
        public static void ValidTimes()
        {
            Console.WriteLine("Enter a time in 24 hour format: ");

            string initialInput = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(initialInput))
            {
                try
                {
                    TimeSpan input = TimeSpan.Parse(initialInput);
                    
                    Console.WriteLine(input + " Valid");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid");
                }
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
