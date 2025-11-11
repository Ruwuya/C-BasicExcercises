using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise41_50
{
    public class Exercise49
    {
        // First or Last Element Equal in Two Arrays

        public static void FirstOrLastElementEqualInTwoArrays()
        {
            Console.WriteLine("Check if the first or last elements of two arrays are equal: ");
            int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] array2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine("First array: [" + string.Join(", ", array1) + "]");
            Console.WriteLine("Second array: [" + string.Join(", ", array2) + "]");
            bool isEqual = (array1[0] == array2[0]) || (array1[array1.Length - 1] == array2[array2.Length - 1]);
            Console.WriteLine("Result: " + isEqual);
        }
    }
}
