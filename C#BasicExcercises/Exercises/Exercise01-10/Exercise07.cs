using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises
{
    public class Exercise07
    {
        // Arithmetic operations
        public static void ArithmeticOperations()
        {
            // Peforms arithmetic operations on two numbers provided by the user
            Console.WriteLine("Arithmetic Operations Exercise");
            Console.WriteLine("Please enter the first number:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            double secondNumber = double.Parse(Console.ReadLine());

            // Performing the basic arithmetic operations
            double add = firstNumber + secondNumber;
            double substract = firstNumber - secondNumber;
            double multiply = firstNumber * secondNumber;
            double divide = firstNumber / secondNumber;
            double modulus = firstNumber % secondNumber;

            // Displaying the results
            Console.WriteLine("The sum of adding the numbers is: " + firstNumber + " and " + secondNumber + " is: " + add);
            Console.WriteLine("The sum of substracting the numbers is: " + secondNumber + " is subtracted from " + firstNumber + " is: " + substract);
            Console.WriteLine("The sum of multiplying the numbers is:  " + firstNumber + " and " + secondNumber + " is: " + multiply);
            Console.WriteLine("The sum of dividing the numbers is: " + firstNumber + " and " + secondNumber + " is " + divide);
            Console.WriteLine("The sum of modulus of the numbers is: " + firstNumber + " and " + secondNumber + " is: " + modulus);
        }
    }
}
