using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises
{
    public class Exercise06
    {
        // Multiply three numbers
        public static void MultiplyThreeNumbers()
        {
            // Takes three numbers as input and display the product of the numbers.
            Console.WriteLine("Multiply Three Numbers Exercise");
            Console.WriteLine("Please enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third number:");
            int thirdNumber = int.Parse(Console.ReadLine());
            int product = firstNumber * secondNumber * thirdNumber;

            Console.WriteLine("The product of " + firstNumber + ", " + secondNumber + ", and " + thirdNumber + " is: " + product);
        }
    }
}
