using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises
{
    public class Exercise03
    {
        // Divide two numbers
        public static void DivideTwoNumbers()
        {
            // This exercise prompts the user to enter two numbers and divides the first number by the second.
            Console.WriteLine("Divide Two Numbers Exercise");
            Console.WriteLine("Please enter the numerator:");
            double numerator = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the denominator:");
            double denominator = double.Parse(Console.ReadLine());
            if (denominator == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                double result = numerator / denominator;
                Console.WriteLine("The result of " + numerator + " divided by " + denominator + " is: " + result);
            }
        }
    }
}
