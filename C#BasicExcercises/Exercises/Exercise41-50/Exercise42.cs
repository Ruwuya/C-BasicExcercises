using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise41_50
{
    public class Exercise42
    {
        // First 4 Chars lowercase but rest uppercase
        // if less than 4 characters, convert all to uppercase
        // example: w3r => W3R

        public static void First4CharsLowercaseLastUppercase()
        {
            Console.WriteLine("Convert first 4 characters to lowercase and last characters to uppercase: ");
            Console.Write("Input a string: ");
            string input = Console.ReadLine();
            if (input.Length < 4)
            {
                string result = input.ToUpper();
                Console.WriteLine("Resulting string: " + result);
            }
            else
            {
                string firstPart = input.Substring(0, 4).ToLower();
                string lastPart = input.Substring(4).ToUpper();
                string result = firstPart + lastPart;
                Console.WriteLine("Resulting string: " + result);
            }
        }
    }
}
