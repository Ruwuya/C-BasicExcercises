using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise41_50
{
    public class Exercise46
    {
        // Check number first or last in array
        public static void CheckNumberFirstOrLastInArray()
        {
            Console.WriteLine("Check if a given number is the first or last element of an array: ");
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.Write("Input a number to check: ");
            int numberToCheck = Convert.ToInt32(Console.ReadLine());

            // Check if the number is the first or last element
            if (numbers.Length == 0)
            {
                Console.WriteLine("The array is empty.");
                return;
            }
            // Check first and last element
            if (numberToCheck == numbers[0] || numberToCheck == numbers[numbers.Length - 1])
            {
                // Output result if it matches
                Console.WriteLine($"{numberToCheck} is either the first or last element of the array.");
            }
            else
            {
                Console.WriteLine($"{numberToCheck} is neither the first nor the last element of the array.");
            }
        }
    }
}
