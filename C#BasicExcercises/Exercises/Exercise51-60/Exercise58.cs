using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise51_60
{
    public class Exercise58
    {
        // Complete Missing Numbers in Range
        // Example:
        // Array = { 1, 3, 4, 7, 9 }
        // Between 1 and 9, the missing numbers are 2, 5, 6, and 8.
        // Output will be 4
        public static void CompleteMissingNumbersInRange()
        {
            int[] array = { 1, 3, 4, 7, 9 };
            int min = array.Min();
            int max = array.Max();

            // Using HashSet for O(1) lookups
            HashSet<int> numbersSet = new HashSet<int>(array);
            int missingCount = 0;

            // Printing the array
            Console.WriteLine("The given array is: " + string.Join(", ", array));

            // Counting missing numbers in the range
            for (int i = min; i <= max; i++)
            {
                // If the number is not in the set, it's missing
                if (!numbersSet.Contains(i))
                {
                    missingCount++;
                }
            }
            Console.WriteLine("The count of missing numbers in the range is: " + missingCount);
        }
    }
}
