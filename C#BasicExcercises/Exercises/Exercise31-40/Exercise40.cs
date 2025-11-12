using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise31_40
{
    public class Exercise40
    {
        // Check nearest value of 20 of two given integers and return 0 if the two numbers are equal

        public static void CheckNearestValueOf20()
        {
            Console.WriteLine("Check which of the two integers is nearest to 20: ");
            Console.Write("Input first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Check if both numbers are equal
            if (num1 == num2)
            {
                Console.WriteLine("Both numbers are the same. Result: 0");
                return;
            }
            // Calculate the absolute differences from 20
            int diff1 = Math.Abs(20 - num1);
            int diff2 = Math.Abs(20 - num2);

            // Determine which number is nearer to 20
            if (diff1 < diff2)
            {
                Console.WriteLine($"{num1} is nearer to 20.");
            }
            else if (diff2 < diff1)
            {
                Console.WriteLine($"{num2} is nearer to 20.");
            }
            else
            {
                Console.WriteLine("Both numbers are equally near to 20.");
            }
        }
    }
}
