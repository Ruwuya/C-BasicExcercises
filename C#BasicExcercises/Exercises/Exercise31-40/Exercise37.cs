using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise31_40
{
    public class Exercise37
    {
        // Remove 'HP' from string

        public static void RemoveHPFromString()
        {
            Console.WriteLine("Remove 'HP' from string: ");
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            // Remove all occurrences of 'HP' of the given string
            if (input != null)
            {
                // Using Replace method to remove 'HP'
                string result = input.Replace("HP", "");
                Console.WriteLine("Resulting string: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
