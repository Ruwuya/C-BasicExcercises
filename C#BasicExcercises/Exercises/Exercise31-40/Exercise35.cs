using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise31_40
{
    public class Exercise35
    {
        // Check numbers less than 100 and greater than 200

        public static void CheckNumbersLessThan100AndGreaterThan200()
        {
            Console.WriteLine("Check if a number is less than 100 or greater than 200: ");
            Console.Write("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // Checks if the number is less than 100 or greater than 200
            if (number < 100 || number > 200)
            {
                // Outputs the result if the number meets the condition
                Console.WriteLine($"{number} is less than 100 or greater than 200.");
            }
            else
            {
                // Outputs the result if the number does not meet the condition
                Console.WriteLine($"{number} is between 100 and 200.");
            }
        }
    }
}
