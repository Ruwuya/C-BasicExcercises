using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises
{
    public class Exercise09
    {
        // Average of four numbers
        public static void AverageOfFourNumbers()
        {
            // Find the average of four numbers entered by the user
            Console.WriteLine("Average of Four Numbers Exercise");

            // Prompt the user to enter four numbers
            Console.WriteLine("Please enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third number:");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the fourth number:");
            int fourthNumber = int.Parse(Console.ReadLine());

            // Calculate the average
            double average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
            Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + ", and " + fourthNumber + " is: " + average);
        }
    }
}
