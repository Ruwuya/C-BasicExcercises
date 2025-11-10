using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise21_30
{
    public class Exercise21
    {
        // Check for 20 or sum equal to 20
        // return true if one of the integers is 20 or if their sum is 20
        public static void CheckFor20OrSumEqualTo20()
        {
            Console.WriteLine("Check for 20 or Sum Equal to 20 Exercise");
            Console.WriteLine("Please enter the first integer:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer:");
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber == 20 || secondNumber == 20 || (firstNumber + secondNumber) == 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
