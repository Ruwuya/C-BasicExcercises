using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise21_30
{
    public class Exercise24
    {
        // Find longest word in a given string.
        public static void FindLongestWord()
        {
            Console.WriteLine("Exercise 24: Find longest word in a given string.");
            Console.Write("Enter a string: ");
            // ?? operator handles null input checks the right side if the left side is null
            string input = Console.ReadLine() ?? string.Empty;
            // Split the input string into words based on whitespace characters
            // \t is tab, \n is new line, \r is carriage return
            string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault() ?? string.Empty;
            Console.WriteLine($"Longest word: {longestWord}");
        }
    }
}
