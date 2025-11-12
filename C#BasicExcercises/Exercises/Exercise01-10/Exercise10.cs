using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises
{
    public class Exercise10
    {
        // Specified formular with three numbers
        public static void SpecifiedFormularWithThreeNumbers()
        {
            // (x + y) * z and (x * y) + (y * z)
            // Get three numbers from the user and calculate the result of the specified formula
            Console.WriteLine("Specified Formular with Three Numbers Exercise");
            Console.WriteLine("Please enter the first number (x):");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number (y):");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third number (z):");
            double z = double.Parse(Console.ReadLine());

            // Calculate the result of the specified formula
            double result = (x + y) * z;
            Console.WriteLine("The result of the specified formula (x + y) * z with x = " + x + ", y = " + y + ", and z = " + z + " is: " + result);

            // Calculate the result of the alternative formula
            double alternativeResult = (x * y) + (y * z);
            Console.WriteLine("The result of the alternative formula (x * y) + (y * z) with x = " + x + ", y = " + y + ", and z = " + z + " is: " + alternativeResult);
        }
    }
}
