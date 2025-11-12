using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise31_40
{
    public class Exercise38
    {
        // Extract 'PH' from string

        public static void ExtractPHFromString()
        {
            Console.WriteLine("Extract 'PH' from string: ");
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            // Extract 'PH' from the input string
            if (input != null)
            {
                // Using StringBuilder for efficient string manipulation
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < input.Length - 1; i++)
                {
                    // Check for 'PH' sequence
                    if (input[i] == 'P' && input[i + 1] == 'H')
                    {
                        result.Append("PH");
                        i++; // Skip the next character as it's already part of 'PH'
                    }
                }
                Console.WriteLine("Resulting string: " + result.ToString());
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
