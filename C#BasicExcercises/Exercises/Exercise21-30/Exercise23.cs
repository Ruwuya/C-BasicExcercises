using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise21_30
{
    public class Exercise23
    {
        // Convert a given string to lowercase.
        public static void ConvertToLowercase()
        {
            Console.WriteLine("Exercise 23: Convert a given string to lowercase.");
            Console.Write("Enter a string: ");
            string input = Console.ReadLine() ?? string.Empty;
            string lowercasedString = input.ToLower();
            Console.WriteLine($"Lowercase string: {lowercasedString}");
        }
    }
}
