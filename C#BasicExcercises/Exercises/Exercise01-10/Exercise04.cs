using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises
{
    public class Exercise04
    {
        // Specified operations result
        public static void SpecifiedOperationsResult()
        {
            // Perform the specified operations and display the results
            // Expected results:
            // 23
            // 5
            // 12
            // 3
            // Operations:
            int firstcalculation = -1 + 4 * 6;
            int secondcalculation = (35 + 5) % 7;
            double thirdcalculation = 14 + -4 * 6 / 11.0;
            double fourthcalculation = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine("Expected Results:\n23\n5\n12\n3");

            // Display the results of the calculations
            Console.WriteLine("Result of the specified operations:");
            Console.WriteLine("1. -1 + 4 * 6 = " + firstcalculation);
            Console.WriteLine("2. (35 + 5) % 7 = " + secondcalculation);
            Console.WriteLine("3. 14 + -4 * 6 / 11 = " + Math.Round(thirdcalculation));
            Console.WriteLine("4. 2 + 15 / 6 * 1 - 7 % 2 = " + Math.Round(fourthcalculation));

        }
    }
}
