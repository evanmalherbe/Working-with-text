using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesC
{
    public class Exercise2
    {
        public static void Duplicates()
        {
        //Exercise1.Consecutives();

        //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

        Console.WriteLine("Enter a few numbers separated by a hyphen '-': ");
            string answer = Console.ReadLine();
        bool duplicate = false;
        List<int> numbers = new List<int>();
            

            if  (answer != null || answer != "")
            {
                string tidyAns = answer.Replace("-", "");

                
                foreach (char num in tidyAns)
                {
                    numbers.Add(Convert.ToInt32(num));
                }

                foreach (char letter in tidyAns)
                {
                    int counter = 0;

                    for(int i = 0; i<numbers.Count; i++)
                    {
                        if (numbers[i] == Convert.ToInt32(letter))
                            counter++;
                    }

                    if (counter == 2)
                    duplicate = true;
                }

                if (duplicate == true)
                    Console.WriteLine("Duplicate");

            }
        }
     }
        
}
