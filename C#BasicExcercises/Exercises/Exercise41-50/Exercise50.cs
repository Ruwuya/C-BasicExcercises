using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise41_50
{
    public class Exercise50
    {
        // Rotate Array left
        // Example:
        // Array1 = { 1, 2, 8 }
        // Result = { 2, 8, 1 }

        public static void RotateArrayLeft()
        {
            Console.WriteLine("Rotate an array left: ");
            int[] array1 = { 1, 2, 8 };
            Console.WriteLine("Original array: [" + string.Join(", ", array1) + "]");

            int firstElement = array1[0];
            // Shift elements to the left
            for (int i = 0; i < array1.Length - 1; i++)
            {
                // Move each element to the left
                array1[i] = array1[i + 1];
            }
            // Place the first element at the end
            array1[array1.Length - 1] = firstElement;
            // Display the rotated array
            Console.WriteLine("Rotated array: [" + string.Join(", ", array1) + "]");
        }
    }
}
