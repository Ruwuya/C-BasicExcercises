using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise11_20
{
    public class Exercise17
    {
        // Add first character to front and back
        // For example, "cat" becomes "ccatc"
        public static void AddFirstCharacterToFrontAndBack()
        {
            // Prompt user for input
            Console.WriteLine("Add First Character to Front and Back Exercise");
            Console.WriteLine("Please enter a string:");
            string inputString = Console.ReadLine();

            // Check if the string is empty
            if (string.IsNullOrEmpty(inputString))
            {
                Console.WriteLine("String is empty.");
            }
            else
            {
                // Get the first character
                char firstChar = inputString[0];
                // Create the new string with first character added to front and back
                string resultString = firstChar + inputString + firstChar;
                // Display the result
                Console.WriteLine("String after adding first character to front and back: " + resultString);
            }
        }
    }
}
