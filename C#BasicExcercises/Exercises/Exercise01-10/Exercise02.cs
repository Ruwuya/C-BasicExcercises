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
            // Prompting the user to enter two numbers
            Console.WriteLine("Sum of two numbers exercise");
            Console.WriteLine("Please enter first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int secondNumber = int.Parse(Console.ReadLine());

            // Calculating the sum and printing it to the console
            int sum = firstNumber + secondNumber;
            Console.WriteLine("The sum of " + firstNumber + " and " + secondNumber + " is: " + sum);
        }
    }
}
