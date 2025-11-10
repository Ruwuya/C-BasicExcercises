using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises
{
    public class Exercise02
    {
        // Sum of two numbers
        public static void SumOfTwoNumbers()
        {
            // Prints the sum of two numbers entered by the user
            Console.WriteLine("Sum of two numbers exercise");
            Console.WriteLine("Please enter first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            Console.WriteLine("The sum of " + firstNumber + " and " + secondNumber + " is: " + sum);
        }
    }
}
