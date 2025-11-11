using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise51_60
{
    public class Exercise53
    {
        // Check Odd Number in array
        // Returns odd number is present in the array or not

        public static void CheckOddNumberInArray()
        {
            int[] array = { 2, 4, 6, 8, 10, 11 };
            bool containsOdd = array.Any(num => num % 2 != 0);
            // Print the array
            Console.WriteLine("Array: { " + string.Join(", ", array) + " }");

            Console.WriteLine("Contains odd number: " + containsOdd);

        }
    }
}
