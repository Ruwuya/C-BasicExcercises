using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise11_20
{
    public class Exercise12
    {
        // Repeat numbers in rows
        // expected output for input 5:
        // 5555
        // 5 5 5 5
        // 5555
        // 5 5 5 5
        public static void RepeatNumbersInRows()
        {
            // Repeat Numbers in Rows Exercise
            Console.WriteLine("Repeat Numbers in Rows Exercise");
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 4; i++)
            {
                if (i % 2 != 0) // Odd rows
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        Console.Write(number);
                    }
                }
                else // Even rows
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
