using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises
{
    public class Exercise05
    {
        // Swap two numbers
        public static void SwapTwoNumbers()
        {
            Console.WriteLine("Swap Two Numbers Exercise");
            Console.WriteLine("Please enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swapping: First Number = " + firstNumber + ", Second Number = " + secondNumber);

            // Swapping using a temporary variable
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("After swapping: First Number = " + firstNumber + ", Second Number = " + secondNumber);
        }
    }
}
