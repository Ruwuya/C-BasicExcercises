using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise51_60
{
    public class Exercise51
    {
        // Max of First and Last in Array
        public static void MaxOfFirstAndLastInArray()
        {
            Console.WriteLine("Max of first and last element in an array: ");
            int[] array1 = { 5, 10, 15, 20, 25 };
            Console.WriteLine("Array: [" + string.Join(", ", array1) + "]");
            int firstElement = array1[0];

            // Takes the length of the array and goes a step back to take the last element
            int lastElement = array1[array1.Length - 1];
            int maxElement = Math.Max(firstElement, lastElement);
            Console.WriteLine("Max of first and last element: " + maxElement);
        }
    }
}
