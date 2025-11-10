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
            Console.WriteLine("Add First Character to Front and Back Exercise");
            Console.WriteLine("Please enter a string:");
            string inputString = Console.ReadLine();
            if (string.IsNullOrEmpty(inputString))
            {
                Console.WriteLine("String is empty.");
            }
            else
            {
                char firstChar = inputString[0];
                string resultString = firstChar + inputString + firstChar;
                Console.WriteLine("String after adding first character to front and back: " + resultString);
            }
        }
    }
}
