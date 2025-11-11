using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise31_40
{
    public class Exercise31
    {
        // Multiply two arrays with user input
        // Example: [1, 3, -5, 4] and [1, 4, -5, -2] => [1, 12, 25, -8]

        public static void MultiplyTwoArrays()
        {
            Console.WriteLine("Multiply two arrays: ");
            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1, 4, -5, -2 };
            Console.WriteLine("First array: ");
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nSecond array: ");
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
            if (array1.Length != array2.Length)
            {
                Console.WriteLine("Arrays must be of the same length.");
                return;
            }
            int[] resultArray = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                resultArray[i] = array1[i] * array2[i];
            }
            Console.WriteLine("\nResulting array: [" + string.Join(", ", resultArray) + "]");
        }
    }
}
