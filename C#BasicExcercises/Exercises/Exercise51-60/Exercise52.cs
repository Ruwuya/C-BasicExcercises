using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise51_60
{
    public class Exercise52
    {
        // Create a new array of length containing the middle elements of three arrays
        // Example:
        // Array1    = {  1, 2 ,5 }
        // Array2    = {  0, 3, 8 }
        // Array3    = { -1, 0, 2 }
        // New Array = {  2, 3, 3 }

        public static void MiddleElementOfArray()
        {
            int[] array1 = { 1, 2, 5 };
            int[] array2 = { 0, 3, 8 };
            int[] array3 = { -1, 0, 2 };
            int[] newArray = { array1[1], array2[1], array3[1] };
            // array1
            Console.WriteLine("Array 1: { " + string.Join(", ", array1) + " }");
            // array2
            Console.WriteLine("Array 2: { " + string.Join(", ", array2) + " }");
            // array3
            Console.WriteLine("Array 3: { " + string.Join(", ", array3) + " }");
            // Print the new array
            Console.WriteLine("New Array: { " + string.Join(", ", newArray) + " }");
        }
    }
}
