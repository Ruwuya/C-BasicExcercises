using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise51_60
{
    public class Exercise59
    {
        // Check whether it is possible to create a strictly increasing sequence from a given array of integers
        public static void CanMakeStrictlyIncreasingSequence()
        {
            int[] array = { 1, 3, 6, 8 };
            int removalCount = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                {
                    removalCount++;
                    if (removalCount > 1)
                    {
                        Console.WriteLine("It is not possible to create a strictly increasing sequence by removing at most one element.");
                        return;
                    }
                    if (i == 1 || array[i] > array[i - 2])
                    {
                        // Remove array[i - 1]
                    }
                    else
                    {
                        // Remove array[i]
                        array[i] = array[i - 1];
                    }
                }
            }
            Console.WriteLine("It is possible to create a strictly increasing sequence by removing at most one element.");
        }
    }
}
