using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise41_50
{
    public class Exercise43
    {
        // Check string starts with 'www'

        public static void CheckStringStartsWithWWW()
        {
            Console.WriteLine("Check if a string starts with 'www': ");
            Console.Write("Input a string: ");
            string inputString = Console.ReadLine();
            if (inputString != null)
            {
                bool startsWithWWW = inputString.StartsWith("www", StringComparison.OrdinalIgnoreCase);
                Console.WriteLine($"Does the string start with 'www'? {startsWithWWW}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
