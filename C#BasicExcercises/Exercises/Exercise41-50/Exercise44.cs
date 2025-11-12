
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise41_50
{
    public class Exercise44
    {
        // Print every other character from a string

        public static void PrintEveryOtherCharacterFromString()
        {
            Console.WriteLine("Print every other character from a string: ");
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            // Validate input
            if (input != null)
            {
                // Build result string with every other character
                StringBuilder result = new StringBuilder();

                // Loop through the string and append every other character
                for (int i = 0; i < input.Length; i += 2)
                {
                    // Append character at index i
                    result.Append(input[i]);
                }
                // Print the resulting string
                Console.WriteLine("Resulting string: " + result.ToString());
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
