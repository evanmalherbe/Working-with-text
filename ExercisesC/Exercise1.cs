using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesC
{
    public class Exercise1
    {
        public static void Consecutives()
        {
            // Exercise 1
            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.Work out if the numbers are consecutive.For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
            Console.WriteLine("Enter a few numbers separated by a hyphen '-': ");
                string answer = Console.ReadLine();
            bool consecutive = false;

            //StringBuilder tidyAnswer = new StringBuilder();
            //tidyAnswer.Replace("-", "");
            string tidyAns = answer.Replace("-", "");
            Console.WriteLine(tidyAns);

                for(int i = 0; i<tidyAns.Length; i++)
                {
                    if (i == 0)
                        continue;
                    else if (Convert.ToInt32(tidyAns[i]) - 1 == Convert.ToInt32(tidyAns[i - 1]))
                    {
                        consecutive = true;
                    }
                }

            if (consecutive)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not consecutive");
            }
        }  
}
