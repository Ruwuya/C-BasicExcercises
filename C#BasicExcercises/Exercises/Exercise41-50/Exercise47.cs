using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise41_50
{
    public class Exercise47
    {
        // Sum of Array Element

        public static void SumOfArrayElement()
        {
            Console.WriteLine("Sum of array elements: ");
            int[] numbers = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 }; // Example array
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number; // Add each element to sum
            }
            Console.WriteLine("The sum of the array elements is: " + sum);
        }
    }
}
