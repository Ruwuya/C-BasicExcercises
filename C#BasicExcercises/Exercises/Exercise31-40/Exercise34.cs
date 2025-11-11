using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise31_40
{
    public class Exercise34
    {
        // Check string starts with word
        // Example: "Hello world" starts with "Hello" => true
        public static void CheckStringStartsWithWord()
        {
            Console.WriteLine("Check if a string starts with a specific word: ");
            Console.Write("Input a string: ");
            string inputString = Console.ReadLine();
            Console.Write("Input the word to check: ");
            string wordToCheck = Console.ReadLine();
            if (inputString != null && wordToCheck != null)
            {
                bool startsWithWord = inputString.StartsWith(wordToCheck);
                Console.WriteLine($"Does the string start with '{wordToCheck}'? {startsWithWord}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
