using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise31_40
{
    public class Exercise39
    {
        // Find largest and lowest values from three numbers
        public static void FindLargestAndLowestFromThreeNumbers()
        {
            // Input three numbers from user
            Console.WriteLine("Find the largest and lowest values from three numbers: ");
            Console.Write("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Determine largest and lowest numbers
            int largest = Math.Max(num1, Math.Max(num2, num3));
            int lowest = Math.Min(num1, Math.Min(num2, num3));

            // Output the results
            Console.WriteLine($"The largest number is: {largest}");
            Console.WriteLine($"The lowest number is: {lowest}");
        }
    }
}
