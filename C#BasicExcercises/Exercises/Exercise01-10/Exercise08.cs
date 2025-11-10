using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises
{
    public class Exercise08
    {
        // Multiplication table
        public static void MultiplicationTable()
        {
            // Makes a multiplication table of a given number
            Console.WriteLine("Multiplication Table Exercise");
            Console.WriteLine("Please enter a number to display its multiplication table:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication Table for {number}:");
            for (int i = 0; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}
