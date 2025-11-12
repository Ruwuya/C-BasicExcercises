using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise51_60
{
    public class Exercise57
    {
        // Max Product of Adjacent integers
        // Find the highest pair of adjacent elements that has the highest product of an array of integers.
        public static void MaxProductOfAdjacentIntegers()
        {
            // Example array
            int[] array = { 3, 6, -2, -5, 7, 3 };
            int maxProduct = int.MinValue;

            // Iterate through the array to find the maximum product of adjacent integers
            for (int i = 0; i < array.Length - 1; i++)
            {
                // Calculate the product of the current pair of adjacent integers
                int product = array[i] * array[i + 1];
                // Update maxProduct if the current product is greater
                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }
            Console.WriteLine("The maximum product of adjacent integers is: " + maxProduct);
        }
    }
}
