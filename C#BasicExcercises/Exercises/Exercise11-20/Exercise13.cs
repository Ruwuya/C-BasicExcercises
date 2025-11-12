using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise11_20
{
    public class Exercise13
    {
        // Rectangle pattern with number
        // expected output for input 5:
        // 555
        // 5 5
        // 5 5
        // 555
        public static void RectanglePatternWithNumber()
        {
            // User input
            Console.WriteLine("Rectangle Pattern with Number Exercise");
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            // Print rectangle pattern
            for (int i = 1; i <= 4; i++)
            {
                // Print each row
                for (int j = 1; j <= 3; j++)
                {
                    // Print number or space based on position
                    // First and last row, first and last column
                    if (i == 1 || i == 4 || j == 1 || j == 3)
                    {
                        // Print the number
                        Console.Write(number);
                    }
                    else
                    {
                        // Print space for inner positions
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
