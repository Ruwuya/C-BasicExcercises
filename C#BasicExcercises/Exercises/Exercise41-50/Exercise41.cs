using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise41_50
{
    public class Exercise41
    {
        // Check 'w' Appears 1-3 times
        public static void CheckWAppears1To3Times()
        {
            Console.WriteLine("Check if 'w' appears between 1 and 3 times in the string: ");
            Console.Write("Input a string: ");
            string inputString = Console.ReadLine();

            // Count occurrences of 'w' and 'W'
            int count = inputString.Count(c => c == 'w' || c == 'W');
            if (count >= 1 && count <= 3)
            {
                // Output the result if 'w' appears between 1 and 3 times
                Console.WriteLine($"The character 'w' appears {count} times, which is between 1 and 3 times.");
            }
            else
            {
                // Output the result if 'w' does not appear between 1 and 3 times
                Console.WriteLine($"The character 'w' appears {count} times, which is not between 1 and 3 times.");
            }
        }
    }
}
