using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise21_30
{
    public class Exercise27
    {
        // Sum of digits int
        // Example: 12 => 3
        public static void SumOfDigitsInt()
        {
            Console.WriteLine("Sum of digits in an integer: ");
            Console.Write("Input an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            // Calculate sum of digits
            while (number != 0)
            {
                sum += number % 10; // Add the last digit to sum
                number /= 10;       // Remove the last digit
            }
            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
