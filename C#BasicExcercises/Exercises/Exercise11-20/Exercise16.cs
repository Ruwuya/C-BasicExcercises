using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_BasicExcercises.Exercises.Exercise11_20
{
    public class Exercise16
    {
        // Swap first and last characters
        // example output: "abcd" => "dbca"
        public static void SwapFirstAndLastCharcater()
        {
            // Prompt user for input
            Console.WriteLine("Swap First and Last Character Exercise");
            Console.WriteLine("Please enter a string:");
            string inputString = Console.ReadLine();
            // Check if the string length is at least 2
            if (inputString.Length < 2)
            {
                Console.WriteLine("String is too short to swap characters.");
            }
            else
            {
                // Swap first and last characters
                char firstChar = inputString[0];
                char lastChar = inputString[inputString.Length - 1];

                // Get the middle substring
                string middleSubstring = inputString.Substring(1, inputString.Length - 2);
                string resultString = lastChar + middleSubstring + firstChar;
                Console.WriteLine("String after swapping first and last characters: " + resultString);
            }
        }
    }
}
