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
            // Print the pattern
            for (int i = 1; i <= 4; i++)
            {
                // Check if the row is odd or even
                if (i % 2 != 0) // Odd rows
                {
                    // Print number without spaces
                    for (int j = 1; j <= 4; j++)
                    {
                        Console.Write(number);
                    }
                }
                else // Even rows
                {
                    // Print number with spaces
                    for (int j = 1; j <= 4; j++)
                    {
                        Console.Write(number + " ");
                    }
                }
                // Move to the next line after each row
                Console.WriteLine();
            }
        }
    }
}
