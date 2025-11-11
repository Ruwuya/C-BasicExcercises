using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise31_40
{
    public class Exercise32
    {
        // Four copies of the last four characters

        public static void FourCopiesOfLastFourCharacters()
        {
            Console.WriteLine("Four copies of the last four characters: ");
            Console.Write("Input a string: ");
            string input = Console.ReadLine();
            if (input.Length < 4)
            {
                Console.WriteLine("Input string must be at least 4 characters long.");
                return;
            }
            string lastFour = input.Substring(input.Length - 4);
            string result = string.Concat(Enumerable.Repeat(lastFour, 4));
            Console.WriteLine("Resulting string: " + result);
        }
    }
}
