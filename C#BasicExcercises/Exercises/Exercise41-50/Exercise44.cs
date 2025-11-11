
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
            if (input != null)
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < input.Length; i += 2)
                {
                    result.Append(input[i]);
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
