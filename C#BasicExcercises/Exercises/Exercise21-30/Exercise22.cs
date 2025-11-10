using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise21_30
{
    public class Exercise22
    {
        // Check within 20 of 100 or 200
        public static void CheckWithin20Of100Or200()
        {
            // If a number is within 20 of 100 or 200 return true
            // otherwise returns false
            // example output: 80 => true, 250 => false
            Console.WriteLine("Check Within 20 of 100 or 200 Exercise");
            Console.WriteLine("Please enter an integer:");
            int number = int.Parse(Console.ReadLine());
            if (Math.Abs(100 - number) <= 20 || Math.Abs(200 - number) <= 20)
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
