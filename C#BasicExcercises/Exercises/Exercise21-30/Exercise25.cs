using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise21_30
{
    public class Exercise25
    {
        // Print odd numbers from 1 to 99.
        public static void PrintOddNumbers()
        {
            Console.WriteLine("Exercise 25: Print odd numbers from 1 to 99.");
            // Searches for the odd numbers from 1 to 99
            for (int i = 1; i < 100; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); // For a new line after printing all numbers
        }
    }
}
