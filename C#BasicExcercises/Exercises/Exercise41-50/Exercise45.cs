using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise41_50
{
    public class Exercise45
    {
        // Count specific number in Array
        public static void CountSpecificNumberInArray()
        {
            Console.WriteLine("Count occurrences of a specific number in an array: ");
            int[] numbers = { 1, 2, 3, 4, 2, 5, 2, 6, 7, 8, 9 };
            Console.Write("Input the number to count: ");
            int numberToCount = Convert.ToInt32(Console.ReadLine());
            int count = numbers.Count(n => n == numberToCount);
            Console.WriteLine($"The number {numberToCount} occurs {count} times in the array.");
        }
    }
}
