using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise_11_20
{
    public class Exercise11
    {
        // Print Age message
        public static void PrintAgeMessage()
        {
            Console.WriteLine("Print Age Message Exercise");
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You look older than: " + age);
        }
    }
}
