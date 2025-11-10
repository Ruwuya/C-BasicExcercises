using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise11_20
{
    public class Exercise18
    {
        // Check positive and negative pair
        public static void CheckPositiveAndNegativePair()
        {
            // A positive and negative pair is defined as one integer being positive and the other being negative.
            // For example, (5, -3) is a positive and negative pair, while (4, 2) and (-1, -6) are not.
            // Takes user input and checks if the pair is a positive and negative pair.
            Console.WriteLine("Check Positive and Negative Pair Exercise");
            Console.WriteLine("Please enter the first integer:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer:");
            int secondNumber = int.Parse(Console.ReadLine());
            if ((firstNumber < 0 && secondNumber > 0) || (firstNumber > 0 && secondNumber < 0))
            {
                Console.WriteLine("The pair has a positive and negative pair.");
            }
            else
            {
                Console.WriteLine("The pair is not a positive and negative pair.");
            }
        }
    }
}
