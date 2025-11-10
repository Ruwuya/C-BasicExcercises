using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise11_20
{
    public class Exercise20
    {
        // Absolute difference or double it
        public static void AbsoluteDifferenceOrDoubleIt()
        {
            // If the first number is greater than the second number return double the absolute difference
            Console.WriteLine("Absolute Difference or Double It Exercise");
            Console.WriteLine("Please enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            int difference = Math.Abs(firstNumber - secondNumber);
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The first number is greater than the second number.");
                Console.WriteLine("Double the absolute difference: " + (difference * 2));
            }
            else
            {
                Console.WriteLine("The absolute difference: " + difference);
            }
        }
    }
}
