using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise51_60
{
    public class Exercise55
    {
        // Max Product of Adjacent Elements in array
        public static void MaxProductOfAdjacentElements()
        {
            int[] array = { 3, 6, -2, -5, 7, 3 };
            int maxProduct = int.MinValue;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int product = array[i] * array[i + 1];
                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }
            // Print the array
            Console.WriteLine("Array: { " + string.Join(", ", array) + " }");
            Console.WriteLine("Maximum product of adjacent elements: " + maxProduct);
        }
    }
}
