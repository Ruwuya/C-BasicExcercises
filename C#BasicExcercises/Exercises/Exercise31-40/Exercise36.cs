using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise31_40
{
    public class Exercise36
    {
        // Check integer in range -10 to 20

        public static void CheckIntegerInRangeMinus10To10()
        {
            Console.WriteLine("Check if an integer is in the range -10 to 10: ");
            Console.Write("Input an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= -10 && number <= 10)
            {
                Console.WriteLine($"{number} is in the range -10 to 10.");
            }
            else
            {
                Console.WriteLine($"{number} is not in the range -10 to 10.");
            }
        }
    }
}
