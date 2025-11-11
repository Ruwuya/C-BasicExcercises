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
            if (number % 3 == 0 || number % 7 == 0)
            {
                Console.WriteLine($"{number} is a multiple of 3 or 7.");
            }
            else
            {
                Console.WriteLine($"{number} is not a multiple of 3 or 7.");
            }
        }
    }
}
