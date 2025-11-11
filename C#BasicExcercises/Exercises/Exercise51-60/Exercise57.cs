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
            Console.WriteLine("The maximum product of adjacent integers is: " + maxProduct);
        }
    }
}
