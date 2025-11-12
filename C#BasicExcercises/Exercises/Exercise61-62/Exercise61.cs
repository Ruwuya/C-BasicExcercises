using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise61_62
{
    public class Exercise61
    {
        // Sort Integers keeping -5 fixed
        // Sort the integers in ascending order without moving the position of -5.
        // Array Example: { -5, 236, 120, 70, -5, -5, 698, 280 }
        // Sorted Output: { -5, 70, 120, 236, -5, -5, 280, 698 }
        public static void SortIntegersKeepingFixed()
        {
            int[] arr = { -5, 236, 120, 70, -5, -5, 698, 280 };
            Console.WriteLine("Original Array: " + string.Join(", ", arr));

            // Extract the elements that are not -5
            List<int> sortableElements = arr.Where(x => x != -5).ToList();

            // Sort the extracted elements
            sortableElements.Sort();
            int sortIndex = 0;

            // Reinsert the sorted elements back into their original positions
            for (int i = 0; i < arr.Length; i++)
            {
                // Skip the -5 elements
                if (arr[i] != -5)
                {
                    arr[i] = sortableElements[sortIndex];
                    sortIndex++;
                }
            }
            Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
        }

    }
}
