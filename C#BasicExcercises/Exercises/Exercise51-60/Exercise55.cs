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
            // Given array
            int[] array = { 3, 6, -2, -5, 7, 3 };
            // Initialize max product variable
            int maxProduct = int.MinValue;

            // Loop through the array to find the maximum product of adjacent elements
            for (int i = 0; i < array.Length - 1; i++)
            {
                // Calculate product of adjacent elements
                int product = array[i] * array[i + 1];
                // Update max product if current product is greater
                if (product > maxProduct)
                {
                    // Update max product
                    maxProduct = product;
                }
            }
            // Print the array
            Console.WriteLine("Array: { " + string.Join(", ", array) + " }");
            Console.WriteLine("Maximum product of adjacent elements: " + maxProduct);
        }
    }
}
