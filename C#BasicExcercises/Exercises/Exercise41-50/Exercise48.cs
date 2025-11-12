using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise41_50
{
    public class Exercise48
    {
        // First and Last Element Equal in Array

        public static void FirstAndLastElementEqualInArray()
        {
            Console.WriteLine("Check if the first and last elements of an array are equal: ");
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("Array: [" + string.Join(", ", array) + "]");

            // Check if the first and last elements are equal
            if (array.Length < 1)
            {
                Console.WriteLine("Array is empty.");
                return;
            }
            // Compare first and last elements
            if (array[0] == array[array.Length - 1])
            {
                // Output the result if they are equal
                Console.WriteLine("The first and last elements are equal.");
            }
            else
            {
                Console.WriteLine("The first and last elements are not equal.");
            }
        }
    }
}
