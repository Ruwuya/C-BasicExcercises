using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise21_30
{
    public class Exercise28
    {
        // Reverse words in a string
        // Example: "Hello World" => "World Hello"
        public static void ReverseWordsInString()
        {
            Console.WriteLine("Reverse words in a string: ");
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            // Split the string into words
            string[] words = input.Split(' ');

            // Reverse the array of words
            Array.Reverse(words);

            // Join the words back into a string
            string reversedString = string.Join(" ", words); 
            Console.WriteLine("Reversed string: " + reversedString);
        }
    }
}
