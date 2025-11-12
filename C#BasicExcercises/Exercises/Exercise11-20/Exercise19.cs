using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise11_20
{
    public class Exercise19
    {
        // Sum or triple sum of integers
        // if two values are the same return triple their sum
        public static void SumOrTripleSumOfIntegers()
        {
            Console.WriteLine("Sum or Triple Sum of Integers Exercise");
            Console.WriteLine("Please enter the first integer:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer:");
            int secondNumber = int.Parse(Console.ReadLine());
            int result;
            // Check if the numbers are the same
            if (firstNumber == secondNumber)
            {
                // Calculate triple the sum if they are the same
                result = 3 * (firstNumber + secondNumber);
            }
            else
            {
                // Calculate the sum if they are different
                result = firstNumber + secondNumber;
            }
            Console.WriteLine("The result is: " + result);

        }
    }
}
