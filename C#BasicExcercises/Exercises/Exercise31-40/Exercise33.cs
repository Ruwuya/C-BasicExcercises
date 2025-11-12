using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise31_40
{
    public class Exercise33
    {
        // Check multiple of 3 or 7
        public static void CheckMultipleOf3Or7()
        {
            Console.WriteLine("Check if a number is a multiple of 3 or 7: ");
            Console.Write("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // Check if the number is a multiple of 3 or 7
            if (number % 3 == 0 || number % 7 == 0)
            {
                // Output the result if it is a multiple of 3 or 7
                Console.WriteLine($"{number} is a multiple of 3 or 7.");
            }
            else
            {
                // Output the result if it is not a multiple of 3 or 7
                Console.WriteLine($"{number} is not a multiple of 3 or 7.");
            }
        }
    }
}
