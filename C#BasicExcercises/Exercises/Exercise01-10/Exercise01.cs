using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises
{
    public class Exercise01
    {
        // Prints Hello and the string you wrote in
        public static void HelloName()
        {
            Console.WriteLine("This is ExerciseHello + name exercise");
            Console.WriteLine("Hello");
            Console.WriteLine("Please enter your name");
            string? name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
